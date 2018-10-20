using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEcommerceApp.Models
{
    public class Common
    {
        public List<Brand> Brands { get; set; }
        public List<Category> Categories { get; set; }
        public List<Color> Colors { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductColors> ProductColors { get; set; }
        public List<ProductImages> ProductImages { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
