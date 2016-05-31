using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SC.Models
{
    public class SampleData : DropCreateDatabaseAlways<SCEntities>
    {
        protected override void Seed(SCEntities context)
        {
            IList<Product> defaultStandards = new List<Product>();

            var products = new List<Product>
            {
                new Product { Name = "Butter", Price = 0.8m, Image="Butter.jpg", Identifier="Buy2Get50Percent" },
                new Product { Name = "Milk", Price = 1.15m, Image="Milk.jpg", Identifier="Buy3OneFree"},
                new Product { Name = "Bread", Price = 1.00m, Image="Bread.jpg", Identifier="Buy2Get50PercentTarget" }
            };

            foreach (Product product in products)
                context.Products.Add(product);

            base.Seed(context);
        }
    }
}