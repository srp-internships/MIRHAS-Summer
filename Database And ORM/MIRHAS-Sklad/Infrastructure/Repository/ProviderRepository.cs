using Domain.Models;
using Domain.Repository;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {
        public ProviderRepository(SkladContext context) : base(context) { }
        public void Remove(int id)
        {
            var entity = context.Providers.Find(id);
            Remove(entity);
        }
        public void Remove(Provider provider)
        {
            context.Remove(provider);
        }

        public void Update(Provider entity)
        {
            var provider = context.Providers.Find(entity.Id);
            if (provider == null)
            {
                throw new Exception("Provider not found");
            }
            provider.Name = entity.Name;
            provider.Phone = entity.Phone;
        }
    }
}
