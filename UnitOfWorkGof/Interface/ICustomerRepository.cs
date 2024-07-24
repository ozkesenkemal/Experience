namespace UnitOfWork.Interface
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetCustomerById(int id);
        IEnumerable<Customer> GetAllCustomers();
    }
}
