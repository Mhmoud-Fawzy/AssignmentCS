using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Department
    {
        #region By Convension
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly HiringDate { get; set; }
        public int InstructorId { get; set; } 
        #endregion

        #region Fluent APIs
        //public int Id { get; set; }
        //public string Name { get; set; } = null!;
        //public DateOnly HiringDate { get; set; }
        //public int InstructorId { get; set; }
      

        #endregion

    }
}
