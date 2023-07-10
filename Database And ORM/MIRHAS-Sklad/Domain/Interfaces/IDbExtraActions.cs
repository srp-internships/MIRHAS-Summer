namespace Domain.Interfaces
{
    public interface IDbExtraActions<T> : IDbCoreActions<T>
    {
        void Remove(T entity);
        void Remove(int id);
        abstract void Update(T entity);
    }
}
