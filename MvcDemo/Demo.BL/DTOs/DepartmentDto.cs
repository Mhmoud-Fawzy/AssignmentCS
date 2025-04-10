using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.DTOs
{
    public class DepartmentDto
    {
        public DepartmentDto()
        {
            
        }
        // Mapping Cons
        public DepartmentDto(Department department)
        {
            DeptId = department.id;
            Name = department.Name;
            Code = department.Code;
            Description = department.Description;
            CreatedOn = department.CreatedOn;

        }
        public int DeptId { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }


    }
}
