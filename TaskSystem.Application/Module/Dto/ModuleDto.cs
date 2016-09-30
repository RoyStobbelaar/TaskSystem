using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Module.Dto
{
   public class ModuleDto : EntityDto
   {
      public string ModuleName { get; set; }

      public string Url { get; set; }

      public string Icon { get; set; }
   }
}
