using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BarcodeLib;
using Microsoft.AspNetCore.Mvc;
using POSSystemWithInventory.ConstantAndHelpers;
using POSSystemWithInventory.Models;
using POSSystemWithInventory.RepositoryPattern.Interfaces.IUnitOfWork;

namespace POSSystemWithInventory.Controllers
{
    public class BarcodeController : Controller
    {
        private readonly IUnitOfWork context;

        public BarcodeController(IUnitOfWork unitOfWork)
        {
            this.context = unitOfWork;
        }
        #region Actions
        public IActionResult GenerateBarcode()
        {
            var productItem = context.Product.GetAll().ToList();
            var barcodeItem = new BarcodeVM()
            {
                ProductItem = POSHelper.Product(productItem),
            };
            return View(barcodeItem);
        }
        [HttpPost]
        public IActionResult GenerateBarcode(BarcodeVM barcodeVM)
        {
            var productItem = context.Product.GetAll().ToList();
            barcodeVM.ProductItem = POSHelper.Product(productItem);
            ViewBag.generateClicked = true;
            return View(barcodeVM);
        }

        [HttpPost]
        public IActionResult PrintBarcode(BarcodeVM barcodeVM)
        {
            return View(barcodeVM);
        }
        public IActionResult GetBarcode(int productId)
        {
            var inventory = context.Inventory.GetAllWithRelatedData().Where(item => item.ProductId == productId).FirstOrDefault();
            try
            {
                
                Barcode barcode = new Barcode();
                barcode.RawData = "Shakil";
                barcode.AlternateLabel = "Price $" + inventory.SellPrice;
                barcode.LabelPosition = LabelPositions.BOTTOMCENTER;
                barcode.IncludeLabel = true;

                Image image = barcode.Encode(TYPE.CODE128B, productId.ToString(), Color.Black, Color.White, 200, 100);

                var data = ConvertImageToByte(image);
                return File(data, "Barcode/png");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Helper
        private byte[] ConvertImageToByte(Image image)
        {
            try
            {
                using MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }

            catch (Exception)
            {

                throw;
            }

        }
        #endregion
    }
}
