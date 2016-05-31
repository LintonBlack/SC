using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC.Models
{
    public class Discount
    {
        public interface IPriceStrategy
        {
            bool IsMatch(Cart item);
            decimal CalculatePrice(Cart item);
        }

        public class BuyThreeGetOneForFree : IPriceStrategy
        {
            public decimal CalculatePrice(Cart item)
            {
                decimal total = 0m;
                total += item.Count * 1m;
                int setsOfThree = item.Count / 3;
                total -= setsOfThree * 1m;
                return total;
            }

            public bool IsMatch(Cart item)
            {
                return item.Identifier.StartsWith("Buy3OneFree");
            }

        }
    }
}