using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    [Table("Stud_Course")]
    public class StudCourse
    {
        [Column("stud_ID")]
        public int StudentID { get; set; }

        [Column("Course_ID")]
        public int CourseID { get; set; }

        public string Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
