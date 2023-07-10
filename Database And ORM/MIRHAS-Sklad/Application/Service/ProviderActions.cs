using Application.Service.Base;
using Domain.Models;
using Infrastructure.Repository;
namespace Application.Service
{
    public class ProviderActions : DbExtraActions<Provider>
    {
        public ProviderActions(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public override void Update(Provider entity)
        {
            unitOfWork.Providers.Update(entity);
            unitOfWork.SaveChanges();
        }
    }
}
