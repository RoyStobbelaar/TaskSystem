using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Module.Dto;

namespace TaskSystem.Module
{
   public class ModuleAppService : IModuleAppService
   {

      public ModuleAppService()
      {

      }

      public GetModuleOutput GetModules()
      {
         //Create and send modules

         ModuleDto dto1 = new ModuleDto() { Id = 1, ModuleName = "User", Url = "/User", Icon = "glyphicon-user" };
         ModuleDto dto2 = new ModuleDto() { Id = 2, ModuleName = "Task", Url = "/Task", Icon = "glyphicon-tasks" };
         ModuleDto dto3 = new ModuleDto() { Id = 3, ModuleName = "Settings", Url = "/Settings", Icon = "glyphicon-cog" };
         ModuleDto dto4 = new ModuleDto() { Id = 4, ModuleName = "Other", Url = "/Other", Icon = "glyphicon-asterisk" };
         ModuleDto dto5 = new ModuleDto() { Id = 5, ModuleName = "Cache", Url = "/Cache", Icon = "glyphicon-trash" };
         ModuleDto dto6 = new ModuleDto() { Id = 6, ModuleName = "Game", Url = "/Game", Icon = "glyphicon-play-circle" };

         GetModuleOutput modules = new GetModuleOutput() { modules = new List<ModuleDto>() };
         modules.modules.Add(dto1);
         modules.modules.Add(dto2);
         modules.modules.Add(dto3);
         modules.modules.Add(dto4);
         modules.modules.Add(dto5);
         modules.modules.Add(dto6);

         return modules;
      }
   }
}
