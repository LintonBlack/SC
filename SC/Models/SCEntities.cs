using System.Data.Entity;

namespace SC.Models
{
    public class SCEntities : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart>
            Carts
        { get; set; }
        public DbSet<Order> Orders
        { get; set; }
        public DbSet<OrderDetail>
            OrderDetails
        { get; set; }
    }
}
