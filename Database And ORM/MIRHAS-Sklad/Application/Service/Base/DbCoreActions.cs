using Domain.Interfaces;
using Domain.Repository;
using Infrastructure.Repository;

namespace Application.Service.Base
{
    public abstract class DbCoreActions<T> : IDbCoreActions<T>
    {
        private UnitOfWork unitOfWork;
        public DbCoreActions(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public virtual void Add(T entity)
        {
            ((IRepository<T>)unitOfWork.Set<T>()).Add(entity);
            unitOfWork.SaveChanges();
        }

        public T? Get(int id)
        {
            return ((IRepository<T>)unitOfWork.Set<T>()).Get(id);
        }

        public List<T> GetAll()
        {
            return ((IRepository<T>)unitOfWork.Set<T>()).GetAll().ToList();
        }
    }
}
