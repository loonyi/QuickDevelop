using Abp.Authorization;
using QuickDevelop.Authorization.Roles;
using QuickDevelop.MultiTenancy;
using QuickDevelop.Users;

namespace QuickDevelop.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
