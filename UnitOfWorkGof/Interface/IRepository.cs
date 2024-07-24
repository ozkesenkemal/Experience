namespace UnitOfWork
{
    public interface IRepository<T> where T : class
    {
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public void Save(T entity);
        public void Delete(int id);
    }
}
