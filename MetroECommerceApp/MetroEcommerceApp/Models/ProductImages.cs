using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEcommerceApp.Models
{
    public class ProductImages
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string PhotoPath { get; set; }

        [Required]
        public bool Visibility { get; set; }
    }
}
