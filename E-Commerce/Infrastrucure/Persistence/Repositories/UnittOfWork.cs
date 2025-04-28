using Domain.Contracts;
using Domain.Models;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class UnittOfWork(StoreDbContext _storeDbContext) : IUnitOfWork
    {
        private readonly Dictionary<string,object>_repositories=[];
        public IGenericRepositry<TEntity, Tkey> GetRepository<TEntity, Tkey>() where TEntity : BaseEntity<Tkey>
        {
            var TypeName = typeof(TEntity).Name;
            if (_repositories.ContainsKey(TypeName))
                return (GenericRepository<TEntity,Tkey>)_repositories[TypeName];

            var repo = new GenericRepository<TEntity, Tkey>(_storeDbContext);
            _repositories[TypeName] =repo;
            return repo;
        }

        public async Task<int> SaveChanges()
        {
            return await _storeDbContext.SaveChangesAsync();
        }
    }
}
