using Demo.DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.Services
{
    internal class DepartmentService
    {
        private readonly IDeptRepo _deptRepo;

        public DepartmentService(IDeptRepo deptRepo)
        {
            _deptRepo = deptRepo;
        }
    }
}
