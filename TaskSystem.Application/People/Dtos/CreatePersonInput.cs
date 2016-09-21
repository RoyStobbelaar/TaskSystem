using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.People.Dtos
{
   public class CreatePersonInput : IInputDto
   {
      [Required]
      public string Name { get; set; }

      [Required]
      public string Job { get; set; }

      public override string ToString()
      {
         return string.Format("[CreatePersonInput > Name = {0}, Job = {1}]", Name,Job);
      }
   }
}