using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using TaskSystem.EntityFramework;

namespace TaskSystem.Migrations
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<TaskSystemDbContext, Configuration>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IIocResolver iocResolver)
            : base(
                unitOfWorkManager,
                connectionStringResolver,
                iocResolver)
        {
        }
    }
}
