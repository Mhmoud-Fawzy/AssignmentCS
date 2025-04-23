using Demo.BLL.Models.Departments;
using Demo.BLL.Services.Employee;
using Demo.DAL.Models.Departments;
using Demo.DAL.Persistence.Repositories.Departments;
using Demo.DAL.Persistence.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Departments
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _UnitOfWork;
        public DepartmentService(IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }

        public async Task<IEnumerable<DepartmentToReturnDto>> GetAllDepartmentsAsync()
        {
            var departmentRepo = _UnitOfWork.DepartmentRepository;

			var department = await departmentRepo.GetIQueryable().Where(D=>!D.IsDeleted).Select(D => new DepartmentToReturnDto
            {
                Id = D.Id,
                Code = D.Code,
                Name = D.Name,
                Description = D.Description,
                CreationDate = D.CreationDate,
            }).AsNoTracking().ToListAsync();
            return department;
        }
        public async Task<DepartmentDetailsToReturnDto?> GetDepartmentByIdAsync(int id)
        {
            var department = await _UnitOfWork.DepartmentRepository.GetByIdAsync(id);
            if (department is not null)
                return new DepartmentDetailsToReturnDto()
                {
                    Id = department.Id,
                    Code = department.Code,
                    Name = department.Name,
                    Description = department.Description,
                    CreationDate = department.CreationDate,
                };
            return null;
        }
        public async Task<int> CreateDepartmentAsync(CreatedDepartmentDto departmentDto)
        {
            var department = new Department()
            {
                Code = departmentDto.Code,
                Name = departmentDto.Name,
                Description = departmentDto.Description,
                CreationDate = departmentDto.CreationDate,
                LastModifiedBy = 1,
                LastModifiedOn = DateTime.UtcNow
            };
            _UnitOfWork.DepartmentRepository.Add(department);
            return await _UnitOfWork.CompleteAsync();
        }
        public async Task<int> UpdateDepartmentAsync(UpdatedDepartmentDto departmentDto)
        {
            var department = new Department()
            {
                Id=departmentDto.Id,
                Code = departmentDto.Code,
                Name = departmentDto.Name,
                Description = departmentDto.Description,
                CreationDate = departmentDto.CreationDate,
                LastModifiedBy = 1,
                LastModifiedOn = DateTime.UtcNow
            };
             _UnitOfWork.DepartmentRepository.Update(department);

            return await _UnitOfWork.CompleteAsync();
        }
        public async Task<bool> DeleteDepartmentAsync(int Id)
        {
            var departmentRepo= _UnitOfWork.DepartmentRepository;

            var department = await departmentRepo.GetByIdAsync(Id);

            if (department is not null)
                 departmentRepo.Delete(department);

            return await _UnitOfWork.CompleteAsync()>0;
        }
    }
}
