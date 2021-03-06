﻿using Microsoft.EntityFrameworkCore;
using POSSystemWithInventory.Data;
using POSSystemWithInventory.EntityModel;
using POSSystemWithInventory.RepositoryPattern.Interfaces.GeneralInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystemWithInventory.RepositoryPattern.Repositories.GeneralRepository
{
    public class PurchaseProductDetailRepository: BaseRepository<PurchaseProductDetail>, IPurchaseProductDetailRepository
    {
        private readonly AppDbContext context;

        public PurchaseProductDetailRepository(AppDbContext appDbContex):base(appDbContex)
        {
            context = appDbContex;
        }
        public IEnumerable<PurchaseProductDetail> GetAllWithRelatedData(string invoiceNumber)
        {
            var result = context.PurchaseProductDetail
                            .Include(x => x.Product)
                                .ThenInclude(x => x.Unit)
                            .Include(x => x.VatAndTax)
                            .Where( x => x.InvoiceNumber == invoiceNumber)
                            .ToList();
            return result;
        }
        public IEnumerable<PurchaseProductDetail> GetAllWithProduct()
        {
            var result = context.PurchaseProductDetail
                        .Include(x => x.Product)
                        .OrderByDescending(x => x.Id)
                        .ToList();
            return result.Distinct().ToList();
        }
    }
}