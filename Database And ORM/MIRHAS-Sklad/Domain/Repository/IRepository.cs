namespace Domain.Repository
{
    public interface IRepository<T>
    {
        void Add(T obj);
        IEnumerable<T> GetAll();
        T? Get(int id);
    }
}
