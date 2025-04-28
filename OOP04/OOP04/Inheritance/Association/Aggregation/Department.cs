using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //Association Relation [Aggregation]  
namespace OOP04.Inherintace.Association.Aggregation
{
    internal class Department
    {
        public int Code { get; set; }
        public required string Name { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
