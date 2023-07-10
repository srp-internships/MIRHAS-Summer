namespace Domain.Interfaces
{
    public interface IDbCoreActions<T>
    {
        void Add(T entity);
        T Get(int id);
        List<T> GetAll();
    }
}
