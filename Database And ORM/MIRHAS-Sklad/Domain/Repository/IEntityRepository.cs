namespace Domain.Repository
{
    public interface IEntityRepository<T> : IRepository<T>
    {
        void Remove(T entity);
        void Remove(int id);
        void Update(T entity);
    }
}
