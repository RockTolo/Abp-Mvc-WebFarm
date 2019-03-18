using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Tolo.MyAbp.Authorization.Users;
using Tolo.MyAbp.Editions;

namespace Tolo.MyAbp.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
