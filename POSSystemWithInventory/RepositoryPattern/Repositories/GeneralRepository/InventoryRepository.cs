using Microsoft.EntityFrameworkCore;
using POSSystemWithInventory.Data;
using POSSystemWithInventory.EntityModel;
using POSSystemWithInventory.RepositoryPattern.Interfaces.GeneralInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystemWithInventory.RepositoryPattern.Repositories.GeneralRepository
{
    public class InventoryRepository:BaseRepository<Inventory>, IInventoryRepository
    {
        private readonly AppDbContext context;

        public InventoryRepository( AppDbContext appDbContext):base(appDbContext)
        {
            context = appDbContext;
        }
        public IEnumerable<Inventory> GetAllWithRelatedData()
        {
            var result = context.Inventory.Include(x => x.Product).ToList();
            return result;
        }
        public IEnumerable<Inventory> OrderableProducts()
        {
            var result = context.Inventory.Include(x => x.Product).Where(x => x.AvailableQuantity <= x.Product.WarningQuantity).ToList();
            return result;
        }
    }
}
