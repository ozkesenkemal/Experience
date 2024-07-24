using System.Data.Entity;

namespace UnitOfWork
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("constr")
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
