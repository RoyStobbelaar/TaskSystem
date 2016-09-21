using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.EntityFramework;

namespace TaskSystem.Migrations.SeedData
{
   public class TestDataCreator
   {
      private readonly TaskSystemDbContext _context;

      public TestDataCreator(TaskSystemDbContext context)
      {
         _context = context;
      }

      public void Create()
      {
         CreateTestData();
      }

      public void CreateTestData()
      {
         _context.Tasks.Add(new Tasks.Task() { Description = "Test Task #1", State = Tasks.TaskState.Active });
         _context.Tasks.Add(new Tasks.Task() { Description = "Test Task #2", State = Tasks.TaskState.Active });
         _context.Tasks.Add(new Tasks.Task() { Description = "Test Task #3", State = Tasks.TaskState.InProgress });
         _context.Tasks.Add(new Tasks.Task() { Description = "Test Task #4", State = Tasks.TaskState.InProgress });
         _context.Tasks.Add(new Tasks.Task() { Description = "Test Task #5", State = Tasks.TaskState.Completed });
         _context.SaveChanges();
      }
   }
}
