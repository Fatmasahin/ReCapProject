using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ReCapProject.Core.Entities;

namespace ReCapProject.Core.DAL
{
    public interface IRepository<T>
        where T:class,IEntity,new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T,bool>>filter);
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
      
    }
}
