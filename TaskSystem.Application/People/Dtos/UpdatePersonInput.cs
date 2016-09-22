using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.People.Dtos
{
   public class UpdatePersonInput : IInputDto
   {
      [Range(1, long.MaxValue)]
      public long PersonId { get; set; }

      public string FirstName { get; set; }

      public string LastName { get; set; }

      public string EmailAddress { get; set; }

      public string Job { get; set; }

      public string Gender { get; set; }
   }
}