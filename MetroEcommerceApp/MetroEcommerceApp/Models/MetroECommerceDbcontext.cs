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
    }
}
