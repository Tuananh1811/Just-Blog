using FA.JustBlog.Core.BaseEntities;
using System.Collections.Generic;

namespace FA.JustBlog.Core.Infrastructures
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Find(int? id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int? id);
        IList<TEntity> GetAll();

    }
}
