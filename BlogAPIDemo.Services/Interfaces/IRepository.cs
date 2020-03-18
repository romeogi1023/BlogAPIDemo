using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogAPIDemo.Services.Interfaces
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);

        TEntity Find(Expression<Func<TEntity, bool>> where);

        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> where);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

    }
}
