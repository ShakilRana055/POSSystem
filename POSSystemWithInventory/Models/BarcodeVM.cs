using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystemWithInventory.Models
{
    public class BarcodeVM
    {
        public BarcodeVM()
        {
            ProductItem = new List<SelectListItem>();
            NumberOfBarcode = 1;
        }
        public List<SelectListItem> ProductItem { get; set; }
        public int ProductId { get; set; }
        public int NumberOfBarcode { get; set; }
        public string ProductName { get; set; }
    }
}
