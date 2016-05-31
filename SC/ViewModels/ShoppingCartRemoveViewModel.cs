using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SC.Models;
namespace SC.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public decimal CartTotal { get; set; }
        public int CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteId { get; set; }
    }
}