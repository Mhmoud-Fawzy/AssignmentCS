using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04.Data.Models
{
    public class EmpDep
    {
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? Id { get; set; }
        public string EmployeeName { get; set; }
    }
}
