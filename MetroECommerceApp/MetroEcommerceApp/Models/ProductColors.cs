﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEcommerceApp.Models
{
    public class ProductColors
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Color Color { get; set; }
    }
}
