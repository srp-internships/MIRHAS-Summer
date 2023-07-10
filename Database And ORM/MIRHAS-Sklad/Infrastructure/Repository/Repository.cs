
using Domain.Repository;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public SkladContext context { get; set; }
        public Repository(SkladContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }
        public T? Get(int id)
        {
            return context.Find<T>(id);
        }
    }
}
