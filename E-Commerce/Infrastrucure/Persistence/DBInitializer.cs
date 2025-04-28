using Domain.Contracts;
using Domain.Models;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Persistence
{
    public class DBInitializer(StoreDbContext _storeDbContext) : IDBInitializer
    {
        public async Task InitializeAsync()
        {
            if (!_storeDbContext.Set<ProductBrand>().Any())
            {
                var data = await File.ReadAllTextAsync(@"..\Infrastrucure\Persistence\Data\Seeding\brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(data);
                if (brands != null && brands.Any())
                {
                    _storeDbContext.Set<ProductBrand>().AddRange(brands);
                }
                await _storeDbContext.SaveChangesAsync();
            }

            if (!_storeDbContext.Set<ProductType>().Any())
            {
                var data = await File.ReadAllTextAsync(@"..\Infrastrucure\Persistence\Data\Seeding\types.json");
                var Types = JsonSerializer.Deserialize<List<ProductType>>(data);
                if (Types != null && Types.Any())
                {
                    _storeDbContext.Set<ProductType>().AddRange(Types);
                }
                await _storeDbContext.SaveChangesAsync();
            }

            if (!_storeDbContext.Set<Product>().Any())
            {
                var data = await File.ReadAllTextAsync(@"..\Infrastrucure\Persistence\Data\Seeding\products.json");
                var Products = JsonSerializer.Deserialize<List<Product>>(data);
                if (Products != null && Products.Any())
                {
                    _storeDbContext.Set<Product>().AddRange(Products);
                }
                await _storeDbContext.SaveChangesAsync();
            }

        }
    }
}
