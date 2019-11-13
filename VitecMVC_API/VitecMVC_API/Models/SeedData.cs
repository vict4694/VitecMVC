using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitecMVC_API.Data;

namespace VitecMVC_API.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VitecMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VitecMVCContext>>()))
            {
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Title = "CD-ORD",
                        ProductDescription = "Til dig, der er pisse blind og bare savner diktat i folkeren",
                        Price = 441
                    },

                    new Product
                    {
                        Title = "Into-Words ",
                        ProductDescription = "Lær at læs nemt af helvede til",
                        Price = 554
                    },

                    new Product
                    {
                        Title = "Læsebriller",
                        ProductDescription = "Hvis du er pisse blind, men kun tæt på",
                        Price = 300
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
