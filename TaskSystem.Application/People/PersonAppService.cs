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

      public void CreatePerson(CreatePersonInput input)
      {
         Logger.Info("Creating a person for input : " + input);

         var person = new Person
         {
            FirstName = input.FirstName,
            LastName = input.LastName,
            EmailAddress = input.EmailAddress,
            Job = input.Job,
            Gender = input.Gender
         };

         _personRepository.Insert(person);
      }

      public void DeletePerson(int personId)
      {
         _personRepository.Delete(personId);
      }

      public GetPersonByIdOutput GetPersonById(int id)
      {
         var person = _personRepository.Get(id);

         Mapper.Initialize(cfg => cfg.CreateMap<Person, PersonDto>());

         PersonDto mappedPerson = Mapper.Map<PersonDto>(person);

         return new GetPersonByIdOutput() { PersonDto = mappedPerson };
      }

      public void UpdatePerson(UpdatePersonInput input)
      {
         var person = _personRepository.Get((int)input.PersonId);

         person.FirstName = input.FirstName;
         person.LastName = input.LastName;
         person.EmailAddress = input.EmailAddress;
         person.Job = input.Job;
         person.Gender = input.Gender;

         Logger.Info("Updating a task for input: " + input);
      }
   }
}
