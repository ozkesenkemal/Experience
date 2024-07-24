namespace UnitOfWork.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        public IOrdersRepository OrdersRepository { get; }
        public ICustomerRepository CustomerRepository { get;  }
    }
}
