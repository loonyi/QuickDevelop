using Abp.Authorization.Roles;
using QuickDevelop.MultiTenancy;
using QuickDevelop.Users;

namespace QuickDevelop.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}