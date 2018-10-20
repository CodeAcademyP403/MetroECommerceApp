using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEcommerceApp.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Path { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
