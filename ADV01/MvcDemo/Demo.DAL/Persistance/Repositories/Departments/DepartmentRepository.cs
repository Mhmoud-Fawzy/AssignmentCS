using LinkDev.IKEA.DAL.Entities.Departments;
using LinkDev.IKEA.DAL.Persistance.Data;
using LinkDev.IKEA.DAL.Persistance.Repositories._Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.DAL.Persistance.Repositories.Departments
{
    public class DepartmentRepository(ApplicationDbContext dbContext) : GenericRepository<Department>(dbContext) , IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext = dbContext;


    }
}
