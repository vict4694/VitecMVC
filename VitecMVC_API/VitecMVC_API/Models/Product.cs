using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitecMVC_API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
    }
}
