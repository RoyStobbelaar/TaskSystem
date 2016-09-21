﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.People;

namespace TaskSystem.Tasks
{
   public enum TaskState : byte
   {
      Active = 1,
      InProgress = 2,
      Completed = 3
   }

   public class Task : Entity<long> 
   {
      [ForeignKey("AssignedPersonId")]
      public virtual Person AssignedPerson { get; set; }

      public virtual int? AssignedPersonId { get; set; }

      public virtual string Description { get; set; }

      public virtual DateTime CreationTime { get; set; }

      public virtual DateTime? CompletionTime { get; set; }

      public virtual TaskState State { get; set; }

      public Task()
      {
         CreationTime = DateTime.Now;
         State = TaskState.Active;
         CompletionTime = null;
      }
   }
}
