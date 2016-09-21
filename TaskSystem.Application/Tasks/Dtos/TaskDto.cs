using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Tasks.Dtos
{
   public class TaskDto : EntityDto<long>
   {
      public int? AssignedPersonId { get; set; }

      public string AssignedPersonName { get; set; }

      public string AssignedPersonJob { get; set; }

      public string Description { get; set; }

      public DateTime Creationtime { get; set; }

      public DateTime CompletionTime { get; set; }

      public byte State { get; set; }

      public override string ToString()
      {
         return string.Format(
            "[Task Id={0}, Description={1}, CreationTime={2}, AssignedPersonName={3}, AssignedPersonJob={4}, State={5}, CompletionTime={6}]",
            Id,
            Description,
            Creationtime,
            AssignedPersonName,
            AssignedPersonJob,
            (TaskState)State,
         CompletionTime);
      }
   }
}
