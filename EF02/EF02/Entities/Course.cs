using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }

        public Topic Topic { get; set; }
        public ICollection<StudCourse> EnrolledStudents { get; set; }
        public ICollection<CourseInst> CourseInstructors { get; set; }
    }
}
