using Microsoft.EntityFrameworkCore;

namespace Application.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }

        public void Add(TEntity entity)
        {
            context.Add(entity);
        }

        public TEntity? Get(int id)
        {
            return context.Find<TEntity>(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }

        public void Remove(int id)
        {
            var entity = context.Find<TEntity>(id);
            context.Remove<TEntity>(entity);
        }

        public void Remove(TEntity entity)
        {
            context.Remove(entity);
        }
    }
}
