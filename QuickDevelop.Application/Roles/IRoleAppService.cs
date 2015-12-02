using System.Threading.Tasks;
using Abp.Application.Services;
using QuickDevelop.Roles.Dto;

namespace QuickDevelop.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
