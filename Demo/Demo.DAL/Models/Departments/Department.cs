using Demo.DAL.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Models.Departments
{
    public class Department : ModelBase
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }

        // Navigational Property [Many]
        public virtual ICollection<Employee> Employees { get; set; }=new HashSet<Employee>();

    }
}
