using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC.Models
{
    public class Product
    {
        
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Identifier { get; set; }
    }
}