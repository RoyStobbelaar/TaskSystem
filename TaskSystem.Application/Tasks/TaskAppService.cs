using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.People;
using TaskSystem.Tasks.Dtos;

namespace TaskSystem.Tasks
{
   public class TaskAppService : ApplicationService, ITaskAppService
   {
      private readonly ITaskRepository _taskRepository;
      private readonly IRepository<Person> _personRepository;

      public TaskAppService(ITaskRepository taskRepository, IRepository<Person> personRepository)
      {
         _taskRepository = taskRepository;
         _personRepository = personRepository;
      }

      public GetTaskOutput GetTasks(GetTaskInput input)
      {
         var tasks = _taskRepository.GetAllWithPeople(input.AssignedPersonId, input.State);

         List<TaskDto> mappedTasks = new List<TaskDto>();

         Mapper.Initialize(cfg => cfg.CreateMap<Task, TaskDto>());


         foreach (Task t in tasks)
         {
            /*Map each task*/
            mappedTasks.Add(Mapper.Map<TaskDto>(t));

         }

         return new GetTaskOutput
         {
            Tasks = mappedTasks
         };


         //Used AutoMapper to automatically convert List<Task> to List<TaskDto>.
         //return new GetTaskOutput
         //{
         //   Tasks = Mapper.Map<List<TaskDto>>(tasks)
         //};
      }

      public void UpdateTask(UpdateTaskInput input)
      {
         Logger.Info("Updating a task for input: " + input);

         var task = _taskRepository.Get(input.TaskId);

         if (input.State.HasValue)
         {
            task.State = input.State.Value;
         }

         if (input.AssignedPersonId.HasValue)
         {
            task.AssignedPerson = _personRepository.Load(input.AssignedPersonId.Value);
         }
      }


      public void CreateTask(CreateTaskInput input)
      {
         Logger.Info("Creating a task for input : " + input);

         var task = new Task { Description = input.Description };

         if (input.AssignedPersonId.HasValue)
         {
            task.AssignedPersonId = input.AssignedPersonId.Value;
         }

         _taskRepository.Insert(task);
      }
   }
}
