namespace UnitOfWork.Interface
{
    public interface IOrdersRepository : IRepository<Order>
    {
        Order GetOrderById(int id);
        IEnumerable<Order> GetAllOrders();
    }
}
