using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string FName { get; set; }

        [Required]
        public string LName { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dep_Id { get; set; }

        public Department Department { get; set; }
        public ICollection<StudCourse> EnrolledCourses { get; set; }
    }
}
