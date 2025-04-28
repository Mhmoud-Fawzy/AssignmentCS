using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
        //IGenericRepositry<Product, int> ProductRepository { get; }
        //IGenericRepositry<Product, int> ProductBrandRepository { get; }
        //IGenericRepositry<Product, int> ProductTypeRepository { get; }

        IGenericRepositry<TEntity,Tkey> GetRepository<TEntity, Tkey>() where TEntity : BaseEntity<Tkey>;


    }
}
