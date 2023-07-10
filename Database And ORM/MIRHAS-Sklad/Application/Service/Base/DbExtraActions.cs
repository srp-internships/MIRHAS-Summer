using Domain.Interfaces;
using Domain.Repository;
using Infrastructure.Repository;
namespace Application.Service.Base;

public abstract class DbExtraActions<T> : DbCoreActions<T>, IDbExtraActions<T>
{
    protected UnitOfWork unitOfWork;
    public DbExtraActions(UnitOfWork unitOfWork) : base(unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public void Remove(T entity)
    {
        ((IEntityRepository<T>)unitOfWork.Set<T>()).Remove(entity);
        unitOfWork.SaveChanges();
    }

    public void Remove(int id)
    {
        ((IEntityRepository<T>)unitOfWork.Set<T>()).Remove(id);
        unitOfWork.SaveChanges();
    }
    public abstract void Update(T entity);
}
