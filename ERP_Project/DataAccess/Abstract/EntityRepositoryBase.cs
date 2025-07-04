using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using DataAccess.Concrete;
using System.Data.Entity;



namespace DataAccess.Abstract
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
                                                                                      where TContext : DbContext, new()
    {


        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {

                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {

                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {

                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {

                return context.Set<TEntity>().SingleOrDefault(filter);
            }

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            // We use generics to create a base for EntityFramework. Here we create context as usual and ask if there is a filter.
            // If there is no filter, we use Set function of EF which creates a subscription to TEntity and gets all the table
            // If there is a filter we choose it by using where
            using (TContext context = new TContext())
            {

                //DropCreateDatabaseAlways: This initializer drops and recreates the database every time the application runs.
                //It is usually used in development and testing scenarios.
                //Database.SetInitializer(new DropCreateDatabaseAlways<TContext>());


                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }

        }

        public List<TEntity> ShowAll(Expression<Func<TEntity, bool>> filter = null,
                                     params Expression<Func<TEntity, object>>[] includes)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> query = context.Set<TEntity>();

                // Apply includes
                if (includes != null)
                {
                    foreach (var include in includes)
                    {
                        query = query.Include(include);
                    }
                }

                // Apply filter
                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return query.ToList();
            }
        }


    }


}

