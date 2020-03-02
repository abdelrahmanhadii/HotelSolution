using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace HotelMVC.DAL
{

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HotelDB _context;

        public GenericRepository(HotelDB context)
        {
            _context = context;

        }
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            var Entity = GetById(id);
            _context.Set<T>().Remove(Entity);
        }

        public IQueryable<T> GetAll(params string[] Includes)

        {
            IQueryable<T> x = _context.Set<T>();
            if (Includes.Length != 0)
            {
                foreach (var Include in Includes)
                {
                    x = x.Include(Include);
                }
            }
            return x;
            // return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(int id, T entity)
        {
            var Entity = GetById(id);
            _context.Entry(Entity).CurrentValues.SetValues(entity);
        }
        public List<T> Find(Expression<Func<T, bool>> Ex, params String[] Includes)
        {
            IQueryable<T> x = GetAll(Includes).AsQueryable();
            IEnumerable<T> data = x.Where(Ex).Select(a => a);
            return data.ToList<T>();
        }
    }
}