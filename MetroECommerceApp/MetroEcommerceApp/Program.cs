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
                        Brand acer = new Brand()
                        {
                            Name = "Acer"
                        };
                        Brand hp = new Brand()
                        {
                            Name = "HP"
                        };
                        Brand polo = new Brand()
                        {
                            Name = "Polo"
                        };

                        metroE.Brands.AddRange(dell, acer, hp, polo);

                        metroE.SaveChanges();







                        SKU sku1 = new SKU()
                        {
                            Name="15.6",
                            
                        };
                        SKU sku2 = new SKU()
                        {
                            Name = "L"
                        };
                        SKU sku3 = new SKU()
                        {
                            Name = "40"
                        };
                        SKU sku4 = new SKU()
                        {
                            Name = "41"
                        };
                        SKU sku5 = new SKU()
                        {
                            Name = "42"
                        };

                        metroE.SKUs.AddRange(sku1, sku2, sku3, sku4, sku5);

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
                            RegularPrice=800,
                            SalesPrice=1000,
                            CategoryId=Computer.Id,
                            Description="Dell Computer",
                            ThumbnailPath="dell.jpg",                          
                        };
                        Product proHP = new Product()
                        {
                            SerialNumber = 54,
                            BrandId = hp.Id,                         
                            RegularPrice = 900,
                            SalesPrice = 1200,
                            CategoryId = Computer.Id,
                            Description = "HP Computer",
                            ThumbnailPath = "hp.jpg"
                        };
                        Product proAcer = new Product()
                        {
                            SerialNumber = 55,
                            BrandId = acer.Id,
                            RegularPrice = 700,
                            SalesPrice = 1000,
                            CategoryId = Computer.Id,
                            Description = "Acer Computer",
                            ThumbnailPath = "acer.jpg"
                        };

                        metroE.Products.AddRange(proDl, proHP, proAcer);

                        metroE.SaveChanges();






                        ProductSKUs ps1 = new ProductSKUs()
                        {
                            Product = proDl,
                            Color = red,
                            SKU = sku1,
                            Count = 5

                        };
                        ProductSKUs ps2 = new ProductSKUs()
                        {
                            Product = proHP,
                            Color = green,
                            SKU = sku1,
                            Count = 3

                        };
                        ProductSKUs ps3 = new ProductSKUs()
                        {
                            Product = proAcer,
                            Color = blue,
                            SKU = sku1,
                            Count = 2

                        };

                        metroE.ProductSKUs.AddRange(ps1, ps2, ps3);

                        metroE.SaveChanges();








                        ProductColors pc1 = new ProductColors()
                        {
                            Product = proDl,
                            Color = red

                        };
                        ProductColors pc2 = new ProductColors()
                        {
                            Product = proHP,
                            Color = green

                        };
                        ProductColors pc3 = new ProductColors()
                        {
                            Product = proAcer,
                            Color = blue

                        };

                        metroE.ProductColors.AddRange(pc1, pc2, pc3);

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
