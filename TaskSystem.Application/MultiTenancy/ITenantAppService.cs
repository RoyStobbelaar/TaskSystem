using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TaskSystem.MultiTenancy.Dto;

namespace TaskSystem.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
