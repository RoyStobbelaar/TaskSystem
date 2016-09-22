using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.People.Dtos
{
   public class GetPersonByIdOutput : IOutputDto
   {
      public PersonDto PersonDto { get; set; }
   }
}
