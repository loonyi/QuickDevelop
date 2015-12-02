using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using QuickDevelop.Authorization.Roles;
using QuickDevelop.Editions;
using QuickDevelop.Users;

namespace QuickDevelop.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}