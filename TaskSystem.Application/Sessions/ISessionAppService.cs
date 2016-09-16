using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using TaskSystem.Sessions.Dto;

namespace TaskSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
