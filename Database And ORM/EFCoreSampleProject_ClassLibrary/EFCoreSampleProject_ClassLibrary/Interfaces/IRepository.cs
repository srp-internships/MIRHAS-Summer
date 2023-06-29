namespace EFCoreSampleProject_ClassLibrary.Interfaces
{
    public interface IRepository<TEntity>
    {
        TEntity? Get(int id);
        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);

        void Remove(int id);
        void Remove(TEntity entity);
    }
}