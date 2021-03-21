using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystemWithInventory.Models
{
    public class OrderableProductVM
    {
        public string Name { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal WarningQuantity { get; set; }
    }
}
