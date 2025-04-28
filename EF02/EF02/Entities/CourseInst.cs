using EF02.Entities;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Course_Inst")]
public class CourseInst
{
    [Column("inst_ID")]
    public int InstructorID { get; set; }

    [Column("Course_ID")]
    public int CourseID { get; set; }

    public string Evaluate { get; set; }

    public Instructor Instructor { get; set; }
    public Course Course { get; set; }
}