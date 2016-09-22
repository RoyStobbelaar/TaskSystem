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
      public string FirstName { get; set; }

      [Required]
      public string LastName { get; set; }

      [Required]
      public string EmailAddress { get; set; }

      [Required]
      public string Job { get; set; }

      [Required]
      public string Gender { get; set; }

      public override string ToString()
      {
         return string.Format("[CreatePersonInput > Name = {0} {1}, {2} , Job = {3}, Email:{4}]", FirstName,LastName,Gender,Job,EmailAddress);
      }
   }
}