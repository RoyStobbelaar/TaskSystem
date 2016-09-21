using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Tasks.Dtos
{
   public class UpdateTaskInput : IInputDto, ICustomValidate
   {
      [Range(1,long.MaxValue)]
      public long TaskId { get; set; }

      public int? AssignedPersonId { get; set; }

      public TaskState? State { get; set; }

      public DateTime CompletionTime { get; set; }

      public void AddValidationErrors(List<ValidationResult> results)
      {
         if(AssignedPersonId == null && State == null)
         {
            results.Add(new ValidationResult("Both of AssignedPersonId and State can not be null in order to update a task!", new[] { "AssignedPersonId", "State" }));
         }
      }

      public override string ToString()
      {
         return string.Format("[UpdateTaskInput > TaskId = {0}, AssignedPersonId = {1}, State = {2}]",TaskId,AssignedPersonId,State);
      }
   }
}
