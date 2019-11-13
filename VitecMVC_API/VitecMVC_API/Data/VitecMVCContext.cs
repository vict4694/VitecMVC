using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitecMVC_API.Models;

namespace VitecMVC_API.Data
{
    public class VitecMVCContext : DbContext
    {
        public VitecMVCContext(DbContextOptions<VitecMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
