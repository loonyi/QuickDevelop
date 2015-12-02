using System.Threading.Tasks;
using Abp.Application.Services;
using QuickDevelop.Users.Dto;

namespace QuickDevelop.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}