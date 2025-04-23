using Demo.BLL.Models.Departments;
using Demo.BLL.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Employee
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeToReturnDto>> GetAllEmployeesAsync(string search);
        Task<EmployeeDetailsToReturnDto?> GetEmployeeByIdAsync(int id);
        Task<int> CreateEmployeeAsync(CreatedEmployeeDto employeeDto);
        Task<int> UpdateEmployeeAsync(UpdatedEmployeeDto employeeDto);
        Task<bool> DeleteEmployeeAsync(int Id);
    }
}
