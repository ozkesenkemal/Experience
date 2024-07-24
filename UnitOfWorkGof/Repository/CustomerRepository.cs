using System.Data.Entity;
using UnitOfWork;
using UnitOfWork.Context;
using UnitOfWork.Interface;

namespace UnitOfWork.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerContext CustomerContext { get { return _dbContext as CustomerContext; } }
        public CustomerRepository(CustomerContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            Console.WriteLine("Customer get all");
            return null;//OrderContext.Customers.Include("").ToList();
        }

        public Customer GetCustomerById(int id)
        {
            Console.WriteLine("Customer get all");
            return null;//OrderContext.Customers.Include("").ToList();
        }
    }
}
