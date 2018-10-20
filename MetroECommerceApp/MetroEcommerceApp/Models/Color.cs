using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEcommerceApp.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public bool Visibility { get; set; }
    }
}
