using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.People.Dtos;

namespace TaskSystem.People
{
   public interface IPersonAppService : IApplicationService
   {
      Task<GetAllPeopleOutput> GetAllPeople();
   }
}
