using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MetroEcommerceApp.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MetroEcommerceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost webHost = CreateWebHostBuilder(args).Build();

            using (IServiceScope serviceScope = webHost.Services.CreateScope())
            {
                using (MetroECommerceDbcontext metroE = serviceScope.ServiceProvider.GetRequiredService<MetroECommerceDbcontext>())
                {
                    if (!metroE.Products.Any())
                    {
                        Color red = new Color()
                        {
                            Name = "red"
                        };
                        Color blue = new Color()
                        {
                            Name = "blue"
                        };
                        Color green = new Color()
                        {
                            Name = "green"
                        };

                        metroE.Colors.AddRange(red,blue,green);

                        metroE.SaveChanges();



                   
                        Brand dell = new Brand()
                        {
                            Name = "Dell"
                        };
                        Brand hp = new Brand()
                        {
                            Name = "HP"
                        };
                        Brand polo = new Brand()
                        {
                            Name = "Polo"
                        };

                        metroE.Brands.AddRange(dell, hp, polo);

                        metroE.SaveChanges();




                    
                        Category Women = new Category()
                        {
                            Name="Women",
                            Icon= "flaticon-dress-1"

                        };
                        Category Men = new Category()
                        {
                            Name = "Men",
                            Icon= "flaticon-polo"
                        };
                        Category Electornics = new Category()
                        {
                            Name = "Electornics",
                            Icon= "flaticon-plug"
                        };
                        Category Jewellery = new Category()
                        {
                            Name = "Jewellery",
                            Icon = "flaticon-necklace"

                        };
                        Category Computer = new Category()
                        {
                            Name = "Computer",
                            Icon = "flaticon-screen"
                        };
                        Category HeadPhone = new Category()
                        {
                            Name = "Head Phone",
                            Icon = "flaticon-headphones"
                        };
                        Category Toys = new Category()
                        {
                            Name = "Toys",
                            Icon = "flaticon-transport"

                        };
                        Category Shoes = new Category()
                        {
                            Name = "Shoes",
                            Icon = "flaticon-fashion"
                        };
                        Category Kid_Wear = new Category()
                        {
                            Name = "Kid’s Wear",
                            Icon = "flaticon-technology"
                        };

                        metroE.Categories.AddRange(Women, Men, Electornics, Jewellery, Computer,
                                                    HeadPhone, Toys, Shoes, Kid_Wear);

                        metroE.SaveChanges();

                        Product proDl = new Product()
                        {
                            SerialNumber=545,
                            BrandId = dell.Id,
                            SKU="xl",
                            RegularPrice=800,
                            SalesPrice=1000,
                            CategoryId=Computer.Id,
                            Description="Default Information",
                            ThumbnailPath="info"
                        };
                        Product proHP = new Product()
                        {
                            SerialNumber = 54,
                            BrandId = dell.Id,
                            SKU = "xl",
                            RegularPrice = 900,
                            SalesPrice = 1200,
                            CategoryId = Computer.Id,
                            Description = "Default Information",
                            ThumbnailPath = "info"
                        };
                        Product ProPolo = new Product()
                        {
                            SerialNumber = 55,
                            BrandId = dell.Id,
                            SKU = "xl",
                            RegularPrice = 700,
                            SalesPrice = 1000,
                            CategoryId = Computer.Id,
                            Description = "Default Information",
                            ThumbnailPath = "info"
                        };

                        metroE.Brands.AddRange(dell, hp, polo);

                        metroE.SaveChanges();
                    }
                }
            }
            
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
