﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Tasks.Dtos
{
   public class GetTaskOutput : IOutputDto
   {
      public List<TaskDto> Tasks { get; set; }
   }
}
