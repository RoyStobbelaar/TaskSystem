using AutoMapper;
using TaskSystem.Tasks;
using TaskSystem.Tasks.Dtos;

namespace TaskSystem
{
   internal static class DtoMappings
   {
      public static void Map()
      {
         //Mapper.CreateMap<Task, TaskDto>().ForMember(t => t.AssignedPersonId, opts => opts.MapFrom(d => d.AssignedPerson.Id));

         Mapper.Initialize(cfg => cfg.CreateMap<Task, TaskDto>());

         //var config = new MapperConfiguration(cfg => cfg.CreateMap<Task, TaskDto>().ForMember(t => t.AssignedPersonId, opts => opts.MapFrom(d => d.AssignedPerson.Id)));

         //IMapper mapper = config.CreateMapper();

         //var source = new Task();
         //var dest = mapper.Map<Task, TaskDto>(source);

      }
   }
}
