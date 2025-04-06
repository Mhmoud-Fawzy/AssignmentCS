using Demo.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repos
{
    public class DeptRepo(AppDbContext appDbContext) : IDeptRepo
    {
        public AppDbContext _appDbContext { get; } = appDbContext;

        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
                return _appDbContext.Departments.ToList();
            else
                return _appDbContext.Departments.AsNoTracking().ToList();
        }
        public Department? GetById(int id)
        {
            return _appDbContext.Departments.Find(id);
        }

        public int Add(Department department)
        {
            _appDbContext.Departments.Add(department);
            return _appDbContext.SaveChanges();
        }


        public int Update(Department department)
        {
            _appDbContext.Departments.Update(department);
            return _appDbContext.SaveChanges();
        }

        public int Remove(Department department)
        {
            _appDbContext.Departments.Remove(department);
            return _appDbContext.SaveChanges();
        }
    }
}
