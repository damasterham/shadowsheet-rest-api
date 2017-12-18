using Microsoft.EntityFrameworkCore;
using ShadowAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Repositories
{
    public abstract class BaseRepository<T, ID> : IRepository<T> where T : BaseEntity
    {
        private DbContext _context;

        public BaseRepository(DbContext context)
        {
            typeof(BaseEntity).GetProperty("id").GetType();

            _context = context;
        }


        public virtual void Create(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Entity " + typeof(T) + " is null");
            _context.Set<T>().Add(entity);
            _context.SaveChanges();

        }


        public T Get(long id)
        {
            return _context.Set<T>().Where(e => e.ID.Equals(id)).SingleOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Entity " + typeof(T) + " is null");
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
