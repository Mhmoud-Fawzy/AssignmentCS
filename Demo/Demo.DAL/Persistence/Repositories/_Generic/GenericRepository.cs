using Demo.DAL.Models;
using Demo.DAL.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Persistence.Repositories._Generic
{
    public class GenericRepository<T> :IGenericRepository<T> where T : ModelBase
    {
        private protected readonly ApplicationDbContext _dbContext;
        public GenericRepository(ApplicationDbContext dbContext) // Ask CLR for Creating Object From ApplicationDbContext 
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> GetIQueryable()
        {
            return _dbContext.Set<T>();
        }
        public IEnumerable<T> GetIEnumerable()
        {
            return _dbContext.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync(bool WithNoTracking = true)
        {
            if (WithNoTracking)
                return await _dbContext.Set<T>().Where(X=>!X.IsDeleted).AsNoTracking().ToListAsync();

            return await _dbContext.Set<T>().Where(X => !X.IsDeleted).ToListAsync();
        }
        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
            /// var T=_dbContext.Ts.Local.Where(D=>D.Id==id).FirstOrDefault();
            ///  if(T==null)
            ///      T = _dbContext.Ts.Where(D => D.Id == id).FirstOrDefault();
            ///  return T;
        }
        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            entity.IsDeleted= true;
            _dbContext.Set<T>().Update(entity);
        }

        
    }
}
