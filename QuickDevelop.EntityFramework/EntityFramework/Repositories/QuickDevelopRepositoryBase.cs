using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace QuickDevelop.EntityFramework.Repositories
{
    public abstract class QuickDevelopRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<QuickDevelopDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected QuickDevelopRepositoryBase(IDbContextProvider<QuickDevelopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class QuickDevelopRepositoryBase<TEntity> : QuickDevelopRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected QuickDevelopRepositoryBase(IDbContextProvider<QuickDevelopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
