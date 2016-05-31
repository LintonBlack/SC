using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC.Models
{
    public class Offer
    {
        public double GetDiscountPrice(double actualPrice, double rate)
            {
                return actualPrice * ( 1 - rate);
            }

    }
}