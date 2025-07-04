using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity , new () // This repository says T must be a classs which is implements  IEntity interface and has a contsructor with no parameters
    {

        List <T> GetAll(Expression<Func<T,bool>> filter =null); //linq expression is added for filtering, but the user doesn't have to filter
        T Get ( Expression<Func<T,bool>> filter); // here in this linq expression, the user has to give a filter entity
        void Add ( T entity);
        void Update (T entity);
        void Delete (T entity);
         List<T> ShowAll(Expression<Func<T, bool>> filter = null,
                                     params Expression<Func<T, object>>[] includes);
    }
}
