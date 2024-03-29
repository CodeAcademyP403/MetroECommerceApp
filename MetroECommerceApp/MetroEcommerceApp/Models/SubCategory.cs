﻿using System;
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
        public string ControllerName { get; set; }
        public string ActionName { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        [Required]
        public bool Visibility { get; set; }
    }
}
