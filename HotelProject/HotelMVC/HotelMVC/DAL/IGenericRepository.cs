using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC.DAL
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll(params string[] Includes);
        T GetById(int id);
        void Update(int id, T entity);
        void Create(T entity);
        void Delete(int id);
        List<T> Find(Expression<Func<T, bool>> Ex, params String[] Includes);
    }
}
