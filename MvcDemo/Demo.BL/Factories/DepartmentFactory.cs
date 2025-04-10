using Demo.BL.DTOs;
using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.Factories
{
    public static class DepartmentFactory
    {
        public static DepartmentDto ToDeptDto(this Department department)
        {
            return new DepartmentDto()
            {
                DeptId = department.id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                CreatedOn = department.CreatedOn
            };
        }


        public static DepartmentDetailsDto DeptDetailsDto(this Department department)
        {
            return new DepartmentDetailsDto()
            {
                DeptId = department.id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                CreatedOn = department.CreatedOn,
                CreatedBy = department.CreatedBy,
                LastModifiedBy = department.LastModifiedBy,
                IsDelated = department.IsDelated

            };
        }

        public static Department ToEntity(this CreateDeptDto dto)
        {
            return new Department()
            {
                Name = dto.Name,
                Code = dto.Code,
                Description = dto.Description,
                CreatedOn = dto.CreatedOn,
            };
        } 
        
       

    }

}
