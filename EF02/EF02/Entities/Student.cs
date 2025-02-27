using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Student
    {
        #region Convension
        //public int Id { get; set; }
        //public int Age { get; set; }
        //public string Adress { get; set; } = null!;
        //public string Fname { get; set; } = null!;
        //public string Lname { get; set; } = null!;
        //public int DepartmentId { get; set; }
        #endregion

     


        #region Fluent APIs
        public int Id { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; } = null!;
        public string Fname { get; set; } = null!;
        public string Lname { get; set; } = null!;
        public int DepartmentId { get; set; }
      
        #endregion


    }
}
