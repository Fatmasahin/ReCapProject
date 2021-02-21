using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ReCapProject.Core.Entities;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ReCapProject.Core.DAL.EntityFramework
{
    public class EFRepositoryBase<T,TContext>:IRepository<T>
        where T:class,IEntity, new()
        where TContext:DbContext,new()
    {
        public void Add(T entity)
        {
            using (TContext context=new TContext())
            {
                var result = context.Entry(entity);
                result.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (TContext context= new TContext())
            {
                var result = context.Entry(entity);
                result.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
                
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (TContext context=new TContext())
            {
                return filter!=null? context.Set<T>().Where(filter).ToList(): context.Set<T>().ToList();
               
            }
        }

        public void Update(T entity)
        {
            using (TContext context=new TContext())
            {
                var result = context.Entry(entity);
                result.State = EntityState.Modified;
                context.SaveChanges();
                
            }
        }
    }
}
