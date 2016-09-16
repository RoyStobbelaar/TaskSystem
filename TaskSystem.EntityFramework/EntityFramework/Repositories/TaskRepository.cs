using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using TaskSystem.Tasks;
using ThreadTask = System.Threading.Tasks.Task;
using System.Data.Entity;

namespace TaskSystem.EntityFramework.Repositories
{
   public class TaskRepository : TaskSystemRepositoryBase<Tasks.Task, long>, ITaskRepository
   {
      public TaskRepository(IDbContextProvider<TaskSystemDbContext> dbContextProvider) : base(dbContextProvider)
      {
      }

      public List<Tasks.Task> GetAllWithPeople(int? assignedPersonId, TaskState? state)
      {

         var query = GetAll();

         if (assignedPersonId.HasValue)
         {
            query = query.Where(task => task.AssignedPerson.Id == assignedPersonId.Value);
         }

         if (state.HasValue)
         {
            query = query.Where(task => task.State == state);
         }

         return query
            .OrderByDescending(task => task.CreationTime)
            .Include(Task => Task.AssignedPerson)
            .ToList();
      }
   }
}