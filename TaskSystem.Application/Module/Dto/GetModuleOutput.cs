using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Module.Dto
{
   public class GetModuleOutput : IOutputDto
   {
      public List<ModuleDto> modules { get; set; }
   }
}
