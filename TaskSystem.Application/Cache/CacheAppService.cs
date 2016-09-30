using Abp.Runtime.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Cache
{
   public class CacheAppService : TaskSystemAppServiceBase, ICacheAppService
   {
      private readonly ICacheManager _cacheManager;

      public CacheAppService(ICacheManager cacheManager)
      {
         _cacheManager = cacheManager;
      }

      public async Task ClearCache()
      {
         var caches = _cacheManager.GetAllCaches();
         foreach (var cache in caches)
            await cache.ClearAsync();
      }
   }
}
