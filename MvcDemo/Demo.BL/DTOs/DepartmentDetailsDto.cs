using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.DTOs
{
    public class DepartmentDetailsDto
    {
        public int DeptId { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public int CreatedBy { get; set; }
        public bool IsDelated { get; set; }

    }
}
