using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public interface IEntityRepository<T>
    {
        void Add(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Update(T entity);
        void Delete(T entity);
    }
}
