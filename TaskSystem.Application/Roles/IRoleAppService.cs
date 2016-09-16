using System.Threading.Tasks;
using Abp.Application.Services;
using TaskSystem.Roles.Dto;

namespace TaskSystem.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
