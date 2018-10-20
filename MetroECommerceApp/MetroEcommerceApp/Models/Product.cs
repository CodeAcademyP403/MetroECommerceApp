using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEcommerceApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public Category Category { get; set; }
        public string SKU { get; set; }
        public Brand Brand { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public string Description { get; set; }
        public string ThumbnailPath { get; set; }
    }
}
