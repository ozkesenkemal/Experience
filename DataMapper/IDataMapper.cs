namespace DataMapper
{
    public interface IDataMapper<T>
    {
        protected string ConnectionString { get; set; }
        int Insert(T entity);
        int Delete(T entity);
        int Update(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
