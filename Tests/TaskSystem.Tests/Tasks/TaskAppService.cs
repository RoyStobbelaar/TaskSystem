using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Tasks;
using TaskSystem.Tasks.Dtos;
using Xunit;

namespace TaskSystem.Tests.Tasks
{
   public class TaskAppService : TaskSystemTestBase
   {
      private readonly ITaskAppService _taskService;

      public TaskAppService()
      {
         _taskService = Resolve<ITaskAppService>();
      }

      [Fact]
      public void Should_Get_All_Tasks()
      {
         //Return all tasks (5)

         var output = _taskService.GetTasks(new GetTaskInput(){ AssignedPersonId = 11, State = TaskState.Completed });

         output.Tasks.Count.ShouldBeGreaterThan(0);
         output.Tasks.Count.ShouldBe(5);
      }


   }
}
