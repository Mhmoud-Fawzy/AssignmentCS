using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Identity.Client;

#nullable disable

namespace EF04.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmpDepView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW EmpDepView  WITH ENCRYPTION, SCHEMABINDING  
                                   AS
                                   SELECT e.Id,e.Name AS EmployeeName, d.DepartmentId,d.Name AS DepartmentName
                                   FROM dbo.Employees e LEFT OUTER JOIN dbo.Departments d  
                                   ON e.DepartmentId = d.DepartmentId;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop View EmpDepView");
        }
    }
}
