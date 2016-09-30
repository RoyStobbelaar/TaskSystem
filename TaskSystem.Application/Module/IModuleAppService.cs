using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Module.Dto;

namespace TaskSystem.Module
{
   public interface IModuleAppService : IApplicationService
   {
      GetModuleOutput GetModules(); //Return all available modules
   }
}
