﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POSSystemWithInventory.ConstantAndHelpers;
using POSSystemWithInventory.EntityModel;
using POSSystemWithInventory.Models;
using POSSystemWithInventory.RepositoryPattern.Interfaces.IUnitOfWork;

namespace POSSystemWithInventory.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IUnitOfWork context;

        public InventoryController(IUnitOfWork unitOfWork)
        {
            context = unitOfWork;
        }

        #region Purchase Product CRUD
        public IActionResult Index()
        {
            var supplierList = context.Supplier.GetAll().ToList();
            var productList = context.Product.GetAll().ToList();
            var vatAndTax = context.VatAndTax.GetAll().ToList();

            PurchaseProductVM purchaseProduct = new PurchaseProductVM()
            {
                SupplierItem = POSHelper.Supplier(supplierList),
                ProductItem = POSHelper.Product(productList),
                VatItem = POSHelper.VatAndTax(vatAndTax),
            };
            return View(purchaseProduct);
        }
        
        [HttpPost]
        public IActionResult Index(PurchaseProductVM purchaseProduct)
        {
            try
            {
                #region Pushing into Purchase Product 
                PurchaseProduct purchase = new PurchaseProduct()
                {
                    InvoiceNumber = purchaseProduct.InvoiceNumber,
                    SupplierId = purchaseProduct.SupplierId,
                    SubTotal = purchaseProduct.SubTotal,
                    GrandTotal = purchaseProduct.GrandTotal,
                    Discount = purchaseProduct.Discount,
                    Dues = purchaseProduct.Dues,
                    PaidAmount = purchaseProduct.PaidAmount,
                    PaymentMode = purchaseProduct.PaymentMode,
                };
                context.PurchaseProduct.Add(purchase);
                context.Save();
                #endregion

                #region Pushing into Purchase Product Detail
                foreach (var item in purchaseProduct.PurchaseProductDetails)
                {
                    PurchaseProductDetail purchaseProductDetail = new PurchaseProductDetail()
                    {
                        PurchaseProductId = purchase.Id,
                        InvoiceNumber = item.InvoiceNumber,
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice,
                        VatAndTaxId = item.VatAndTaxId,
                        BasePrice = item.BasePrice,
                        SellPrice = item.SellPrice,
                    };
                    context.PurchaseProductDetail.Add(purchaseProductDetail);
                    context.Save();
                    UpdateInventory(item.ProductId, item.Quantity, item.SellPrice);
                }

                #endregion

                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
                throw ex;
            }
        }
        public IActionResult PurchaseList()
        {
            return View();
        }
        public IActionResult PurchaseInformation(string search)
        {
            string invoiceNumber = search;
            var purchaseProduct = context.PurchaseProduct.GetAllWithRelatedData(invoiceNumber);
            purchaseProduct.UpdatedBy = POSHelper.AmountInWords(purchaseProduct.GrandTotal);
            purchaseProduct.PurchaseProductDetail = context.PurchaseProductDetail.GetAllWithRelatedData(invoiceNumber).ToList();
            return PartialView("_PurchaseInformation", purchaseProduct);
        }
        #endregion

        #region Actions & Helpers 
        private void UpdateInventory(int? productId, decimal quantity, decimal sellPrice)
        {
            var inventory = context.Inventory.Find(x => x.ProductId == productId).FirstOrDefault();
            if(inventory != null)
            {
                inventory.AvailableQuantity = inventory.AvailableQuantity + quantity;
                inventory.UpdatedDate = DateTime.Now.ToShortDateString();
                inventory.SellPrice = sellPrice;
                context.Save();
            }
            return;
        }
        private string GetInvoiceNumber()
        {
            var purchaseLastEntry = context.PurchaseProduct.GetLastOrDefault();
            string invoiceNumber = AutoGeneratedNumber.GetStockNumber(purchaseLastEntry == null ? "1" : purchaseLastEntry.InvoiceNumber );
            return invoiceNumber;
        }
        public IActionResult InvoiceNumber()
        {
            string invoiceNumber = GetInvoiceNumber();
            return Json(invoiceNumber);
        }
        public IActionResult GetPurchaseList()
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault().ToLower();

            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;

            var purchaseProductList = context.PurchaseProduct.GetAllWithRelatedData();

            #region Filtering table data
            // searching 
            if (searchValue != null)
            {
                try
                {
                    var filteredProductList = purchaseProductList.Where(
                        x => x.InvoiceNumber.ToLower().Contains(searchValue) ||
                        x.CreatedDate.ToLower().Contains(searchValue) ||
                        x.Supplier.Name.ToLower().Contains(searchValue) 
                        ).ToList();
                    purchaseProductList = filteredProductList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            #endregion

            var lists = purchaseProductList.OrderByDescending(x => x.Id).ToList();

            //total number of rows count     
            recordsTotal = lists.Count();

            //Paging     
            var data = lists.Skip(skip).Take(pageSize).ToList();

            //Returning Json Data    
            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }
        public IActionResult GetPurchaseDetailList()
        {
            var purchaseProductDetailList = context.PurchaseProductDetail.GetAllWithProduct();
            return Json(purchaseProductDetailList);
        }
        #endregion

        #region Accounts Payable
        public IActionResult AccountPay()
        {
            var supplier = context.Supplier.GetAll().ToList();
            PurchaseProductVM purchaseProductVM = new PurchaseProductVM()
            {
                SupplierItem = POSHelper.Supplier(supplier),
            };
            return View(purchaseProductVM);
        }
        [HttpPost]
        public IActionResult AccountPay(PurchaseProductVM purchaseProduct)
        {
            try
            {
                foreach (var item in purchaseProduct.PurchaseProducts)
                {
                    var purchase = context.PurchaseProduct.Find(x => x.InvoiceNumber == item.InvoiceNumber).FirstOrDefault();
                    if(purchase != null)
                    {
                        purchase.PaidAmount = purchase.GrandTotal;
                        purchase.Dues = 0;
                        context.Save();
                    }
                }
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(false);
                throw ex;
            }
        }
        public IActionResult GetDuesBySupplier(int search)
        {
            var dues = context.PurchaseProduct.GetDuesBySupplier(search);
            return Json(dues);
        }
        #endregion
    }
}
