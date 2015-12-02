using Abp.MultiTenancy;
using QuickDevelop.Users;

namespace QuickDevelop.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}