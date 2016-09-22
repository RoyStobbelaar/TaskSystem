using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Tasks.Dtos;

namespace TaskSystem.Tasks
{
   public interface ITaskAppService : IApplicationService
   {
      GetTaskOutput GetTasks(GetTaskInput input);
      GetTaskByIdOutput GetTask(int id);
      void UpdateTask(UpdateTaskInput input);
      void CreateTask(CreateTaskInput input);
      void DeleteTask(int id);
   }
}
