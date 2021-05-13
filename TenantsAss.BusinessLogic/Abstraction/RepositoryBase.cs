using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using TenantsAss.DataModel;
using TenantsAss.DataAccess;

namespace TenantsAss.BusinessLogic.Abstraction
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected TenantsAssDbContext TenantsAssDbContext { get; set; }

        public RepositoryBase(TenantsAssDbContext tenantsAssDbContext)
        {
            this.TenantsAssDbContext = tenantsAssDbContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.TenantsAssDbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.TenantsAssDbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.TenantsAssDbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.TenantsAssDbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.TenantsAssDbContext.Set<T>().Remove(entity);
        }

    }
}
