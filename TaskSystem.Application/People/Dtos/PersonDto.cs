using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.People.Dtos
{
   [AutoMapFrom(typeof(Person))]
   public class PersonDto : EntityDto
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string EmailAddress { get; set; }
      public string Job { get; set; }
      public string Gender { get; set; }
   }
}
