using Abp.Application.Features;
using QuickDevelop.Authorization.Roles;
using QuickDevelop.MultiTenancy;
using QuickDevelop.Users;

namespace QuickDevelop.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}