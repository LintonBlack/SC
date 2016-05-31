using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal Total { get; set; }
        public System.DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}