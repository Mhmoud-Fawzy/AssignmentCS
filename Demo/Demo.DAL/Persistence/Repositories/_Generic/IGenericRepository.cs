using Demo.DAL.Models;
using Demo.DAL.Models.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Persistence.Repositories._Generic
{
    public interface IGenericRepository<T>where T : ModelBase
    {
		Task<T?> GetByIdAsync(int id);
		Task<IEnumerable<T>> GetAllAsync(bool WithNoTracking = false);
        IQueryable<T> GetIQueryable();
        IEnumerable<T> GetIEnumerable();
		void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
