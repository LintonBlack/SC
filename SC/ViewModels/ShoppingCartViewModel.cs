﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SC.Models;

namespace SC.ViewModels
{
    public class ShoppingCartViewModel
    {
        public decimal CartDiscount { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}