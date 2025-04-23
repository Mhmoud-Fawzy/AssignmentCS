using Demo.BLL.Common.Services.Attachments;
using Demo.BLL.Models.Employees;
using Demo.BLL.Services.Employee;
using Demo.DAL.Models.Departments;
using Demo.DAL.Models.Employees;
using Demo.DAL.Persistence.Repositories.Employees;
using Demo.DAL.Persistence.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IAttachmentService _attachmentService;

        public EmployeeService(IUnitOfWork UnitOfWork,IAttachmentService attachmentService) // Ask CLR for Creating Object from class Implement IUnitOfWork
        {
            _UnitOfWork = UnitOfWork;
           _attachmentService = attachmentService;
        }

        public async Task<IEnumerable<EmployeeToReturnDto>> GetAllEmployeesAsync(string search)
        {
            var employees= await _UnitOfWork.EmployeeRepository
                .GetIQueryable()
                .Where(E=>!E.IsDeleted && (string.IsNullOrEmpty(search) || E.Name.ToLower().Contains(search.ToLower()))) 
                .Include(E=>E.Department)
                .Select(employee => new EmployeeToReturnDto()
                {
                Id = employee.Id,
                Name = employee.Name,
                Age = employee.Age,
                IsActive = employee.IsActive,
                Salary = employee.Salary,
                Email = employee.Email,
                Gender = employee.Gender.ToString(),
                EmployeeType =employee.EmployeeType.ToString(),
                Department=employee.Department.Name,
                DepartmentId=employee.Department.Id,
                Image=employee.Image
                }).ToListAsync();
            return employees;
        }
        public async Task<EmployeeDetailsToReturnDto?> GetEmployeeByIdAsync(int id)
        {
            var employee = await _UnitOfWork.EmployeeRepository.GetByIdAsync(id);

            if (employee is not null)
                return new EmployeeDetailsToReturnDto()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Age = employee.Age,
                    Address = employee.Address,
                    IsActive = employee.IsActive,
                    Salary = employee.Salary,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    HiringDate = employee.HiringDate,
                    Gender = employee.Gender,
                    EmployeeType = employee.EmployeeType,
                    Department=employee.Department?.Name,
					Image = employee.Image,
				};
            return null;
        }
		public async Task<int> CreateEmployeeAsync(CreatedEmployeeDto employeeDto)
        {
            var employee = new DAL.Models.Employees.Employee()
            {
                Name = employeeDto.Name,
                Age = employeeDto.Age,
                Address = employeeDto.Address,
                IsActive = employeeDto.IsActive,
                Salary = employeeDto.Salary,
                Email = employeeDto.Email,
                PhoneNumber = employeeDto.PhoneNumber,
                HiringDate = employeeDto.HiringDate,
                Gender = employeeDto.Gender,
                EmployeeType = employeeDto.EmployeeType,
                DepartmentId= employeeDto.DepartmentId,
                CreatedBy = 1,
                LastModifiedBy = 1,
                LastModifiedOn = DateTime.UtcNow,
            };

            if(employeeDto.Image is not null)
                employee.Image=await _attachmentService.UploadAsync(employeeDto.Image,"images");

            _UnitOfWork.EmployeeRepository.Add(employee);
            return await _UnitOfWork.CompleteAsync();
        }
        public async Task<int> UpdateEmployeeAsync(UpdatedEmployeeDto employeeDto)
        {

			var employee = new DAL.Models.Employees.Employee()
            {
                Id = employeeDto.Id,
                Name = employeeDto.Name,
                Age = employeeDto.Age,
                Address = employeeDto.Address,
                IsActive = employeeDto.IsActive,
                Salary = employeeDto.Salary,
                Email = employeeDto.Email,
                PhoneNumber = employeeDto.PhoneNumber,
                HiringDate = employeeDto.HiringDate,
                Gender = employeeDto.Gender,
                EmployeeType = employeeDto.EmployeeType,
                DepartmentId=employeeDto.DepartmentId,
                CreatedBy = 1,
                LastModifiedBy = 1,
                LastModifiedOn = DateTime.UtcNow,
            };

			if (employeeDto.Image is not null)
				employee.Image = await _attachmentService.UploadAsync(employeeDto.Image, "images");

			_UnitOfWork.EmployeeRepository.Update(employee);
            return await _UnitOfWork.CompleteAsync();
        }
        public async Task<bool> DeleteEmployeeAsync(int Id)
        {
            var employeeRepo = _UnitOfWork.EmployeeRepository;

            var employee= await employeeRepo.GetByIdAsync(Id);

            if(employee is not null)
                employeeRepo.Delete(employee);

            return await _UnitOfWork.CompleteAsync()>0;
        }
    }
}
