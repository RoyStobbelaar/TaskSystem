using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TaskSystem.EntityFramework.Repositories
{
    public abstract class TaskSystemRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TaskSystemDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TaskSystemRepositoryBase(IDbContextProvider<TaskSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TaskSystemRepositoryBase<TEntity> : TaskSystemRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TaskSystemRepositoryBase(IDbContextProvider<TaskSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
