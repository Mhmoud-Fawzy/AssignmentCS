using Demo.DAL.Persistence.Repositories.Departments;
using Demo.DAL.Persistence.Repositories.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Persistence.UnitOfWork
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        Task<int> CompleteAsync();
    }
}
