using System.Data.Entity;

namespace UnitOfWork
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext _dbContext;
        private DbSet<T> _dbSet;
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public void Delete(int id)
        {
            _dbSet.Remove(GetById(id));
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Save(T entity)
        {
            //_dbContext.Set<T>().Add(entity);
            _dbSet.Add(entity);
        }
    }
}
