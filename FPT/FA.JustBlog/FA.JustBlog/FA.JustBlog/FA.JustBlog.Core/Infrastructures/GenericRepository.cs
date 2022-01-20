using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FA.JustBlog.Core.Infrastructures
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly JustBlogContext context;
        protected DbSet<TEntity> dbSet;

        public GenericRepository(JustBlogContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            this.dbSet.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public virtual void Delete(int? id)
        {
            var entity = dbSet.Find(id);
            this.dbSet.Remove(entity);
        }

        public virtual TEntity Find(int? id)
        {
            return this.dbSet.Find(id);
        }

        public virtual IList<TEntity> GetAll()
        {
            return this.dbSet.ToList();
        }

        public virtual void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
