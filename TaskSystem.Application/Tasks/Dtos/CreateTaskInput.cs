﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Tasks.Dtos
{
   public class CreateTaskInput : IInputDto
   {
      public int? AssignedPersonId { get; set; }

      public DateTime CompletionTime { get; set; }

      [Required]
      public string Description { get; set; }

      [Required]
      public string Title { get; set; }

      public override string ToString()
      {
         return string.Format("[CreateTaskInput > AssignedPersonId = {0}, Description = {1}, Title = {2}]", AssignedPersonId, Description, Title);
      }
   }
}
