using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEcommerceApp.Models
{
    public class MetroECommerceDbcontext:DbContext
    {
        public MetroECommerceDbcontext(DbContextOptions<MetroECommerceDbcontext> dbContextOptions):base(dbContextOptions)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<ProductImages> ProductImages { get; set; }
        public virtual DbSet<ProductColors> ProductColors { get; set; }
    }
}
