using EF02.Entities;
using Microsoft.EntityFrameworkCore;

public class ITIDbContext : DbContext
{

    public ITIDbContext(){ }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = .; Database = ITIDb; Trusted_Connection = true; TrustServerCertificate = True;");
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<StudCourse> StudCourses { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<CourseInst> CourseInstructors { get; set; }
    public DbSet<Instructor> Instructors { get; set; }

    public ITIDbContext(DbContextOptions<ITIDbContext> options)
        : base(options)
    {
    }

   


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudCourse>()
            .HasKey(sc => new { sc.StudentID, sc.CourseID });

        modelBuilder.Entity<StudCourse>()
            .HasOne(sc => sc.Student)
            .WithMany(s => s.EnrolledCourses)
            .HasForeignKey(sc => sc.StudentID);

        modelBuilder.Entity<StudCourse>()
            .HasOne(sc => sc.Course)
            .WithMany(c => c.EnrolledStudents)
            .HasForeignKey(sc => sc.CourseID);

        modelBuilder.Entity<CourseInst>()
            .HasKey(ci => new { ci.InstructorID, ci.CourseID });

        modelBuilder.Entity<CourseInst>()
            .HasOne(ci => ci.Instructor)
            .WithMany(i => i.InstructorCourses)
            .HasForeignKey(ci => ci.InstructorID);

        modelBuilder.Entity<CourseInst>()
            .HasOne(ci => ci.Course)
            .WithMany(c => c.CourseInstructors)
            .HasForeignKey(ci => ci.CourseID);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.Department)
            .WithMany(d => d.Students)
            .HasForeignKey(s => s.Dep_Id);

        modelBuilder.Entity<Course>()
            .HasOne(c => c.Topic)
            .WithMany(t => t.Courses)
            .HasForeignKey(c => c.Top_ID);

        modelBuilder.Entity<Instructor>()
            .HasOne(i => i.Department)
            .WithMany(d => d.Instructors)
            .HasForeignKey(i => i.Dept_ID);

        modelBuilder.Entity<Instructor>()
            .Property(i => i.Name)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<Instructor>()
            .Property(i => i.Salary);

        modelBuilder.Entity<Instructor>()
            .Property(i => i.HourRate);

        modelBuilder.Entity<Instructor>()
            .Property(i => i.Bonus);

        modelBuilder.Entity<Topic>()
            .Property(t => t.Name)
            .IsRequired();
    }
}