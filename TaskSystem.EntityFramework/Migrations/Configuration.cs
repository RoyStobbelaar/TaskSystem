using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using TaskSystem.Migrations.SeedData;
using EntityFramework.DynamicFilters;
using TaskSystem.People;

namespace TaskSystem.Migrations
{
   public sealed class Configuration : DbMigrationsConfiguration<TaskSystem.EntityFramework.TaskSystemDbContext>, IMultiTenantSeed
   {
      public AbpTenantBase Tenant { get; set; }

      public Configuration()
      {
         AutomaticMigrationsEnabled = false;
         ContextKey = "TaskSystem";
      }

      protected override void Seed(TaskSystem.EntityFramework.TaskSystemDbContext context)
      {
         context.DisableAllFilters();

         if (Tenant == null)
         {
            //Host seed
            new InitialHostDbBuilder(context).Create();

            //Default tenant seed (in host database).
            new DefaultTenantCreator(context).Create();
            new TenantRoleAndUserBuilder(context, 1).Create();
         }
         else
         {
            //You can add seed for tenant databases and use Tenant property...
         }

         //Create some sample people
         context.People.AddOrUpdate(
            p => p.Name,
            new Person { Name = "Ryo Takashi" },
            new Person { Name = "Miya Shuzo" },
            new Person { Name = "Kazura Ryozaki" },
            new Person { Name = "Yamato Kishi" }
            );
         context.SaveChanges();
      }
   }
}
