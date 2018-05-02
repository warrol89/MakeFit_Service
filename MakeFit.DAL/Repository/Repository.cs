using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MakeFit.DAL
{
   public class GenericRepository<T> where T: class
    {
        
        internal readonly MakeFitEntities _db;
        internal DbSet<T> _dbSet;
        public GenericRepository(MakeFitEntities Context)
        {
            Context.Configuration.LazyLoadingEnabled = false;
            _db = Context;
          
            _dbSet = _db.Set<T>();         
        }
        
        public virtual T GetSingle(int Id)
        {
            
            return _dbSet.Find(Id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);

        }
        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
            
            _db.SaveChanges();

        }
    }
}
