using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.People
{
   public class Person : Entity
   {
      public virtual string FirstName { get; set; }

      public virtual string LastName { get; set; }

      public virtual string EmailAddress { get; set; }

      public virtual string Job { get; set; }

      public virtual string Gender { get; set; }

   }
}
