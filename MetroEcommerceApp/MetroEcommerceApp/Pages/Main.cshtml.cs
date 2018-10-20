using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetroEcommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MetroEcommerceApp.Pages
{
    public class MainModel : PageModel
    {
        private readonly MetroECommerceDbcontext _context;
        public MainModel(MetroECommerceDbcontext context )
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            var brands = await _context.Brands
                                    .Where(x => x.Visibility == true)
                                        .ToListAsync();

            var categories = await _context.Categories
                                        .Where(x => x.Visibility == true)
                                            .ToListAsync();

            var colors = await _context.Colors
                                        .Where(x => x.Visibility == true)
                                            .ToListAsync();

            var products = await _context.Products
                                        .Where(x => x.Visibility == true)
                                            .ToListAsync();

            var productColors = await _context.ProductColors
                                        .Where(x => x.Visibility == true)
                                            .ToListAsync();

            var productImages = await _context.ProductImages
                                        .Where(x => x.Visibility == true)
                                            .ToListAsync();

            var subCat = await _context.SubCategories
                                        .Where(x => x.Visibility == true)
                                            .ToListAsync();


            Common common = new Common
            {
                Brands = brands,
                Categories = categories,
                Colors = colors,
                Products = products,
                ProductImages = productImages,
                ProductColors = productColors,
                SubCategories = subCat
            };

            return RedirectToPage(common);
        }
    }
}