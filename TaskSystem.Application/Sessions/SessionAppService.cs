using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.AutoMapper;
using TaskSystem.Sessions.Dto;

namespace TaskSystem.Sessions
{
    [AbpAuthorize]
    public class SessionAppService : TaskSystemAppServiceBase, ISessionAppService
    {
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput
            {
                User = (await GetCurrentUserAsync()).MapTo<UserLoginInfoDto>()
            };

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = (await GetCurrentTenantAsync()).MapTo<TenantLoginInfoDto>();
            }

            return output;
        }
    }
}