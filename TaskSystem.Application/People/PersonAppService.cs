using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.People.Dtos;

namespace TaskSystem.People
{
   public class PersonAppService : ApplicationService, IPersonAppService
   {
      private readonly IRepository<Person> _personRepository;

      public PersonAppService(IRepository<Person> personRepository)
      {
         _personRepository = personRepository;
      }

      public async Task<GetAllPeopleOutput> GetAllPeople()
      {
         var people = await _personRepository.GetAllListAsync();

         Mapper.Initialize(cfg => cfg.CreateMap<Person, PersonDto>());

         return new GetAllPeopleOutput
         {
            People = people.MapTo<List<PersonDto>>()
         };
      }
   }
}
