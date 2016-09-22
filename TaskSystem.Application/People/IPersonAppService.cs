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
      void CreatePerson(CreatePersonInput input);
      void DeletePerson(int id);
      GetPersonByIdOutput GetPersonById(int id);
      void UpdatePerson(UpdatePersonInput input);
   }
}
