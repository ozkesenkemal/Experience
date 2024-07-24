using System.Data.Entity;
using UnitOfWork.Interface;

namespace UnitOfWork.Repository
{
    public class OrderRepository : Repository<Order>, IOrdersRepository
    {
        public OrderContext OrderContext { get { return _dbContext as OrderContext} }
        public OrderRepository(OrderContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Order> GetAllOrders()
        {
            Console.WriteLine("order get all");
            return null;//OrderContext.Customers.Include("").ToList();
        }

        public Order GetOrderById(int id)
        {
            Console.WriteLine("order get by id");
            return null;
        }
    }
}
