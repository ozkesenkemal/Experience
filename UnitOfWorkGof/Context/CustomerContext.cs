using System.Data.Entity;

namespace UnitOfWork.Context
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("connstr")
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
