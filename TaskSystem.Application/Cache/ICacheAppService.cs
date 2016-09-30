using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Cache
{
   public interface ICacheAppService : IApplicationService
   {
      Task ClearCache();//Clears whole cache
   }
}
