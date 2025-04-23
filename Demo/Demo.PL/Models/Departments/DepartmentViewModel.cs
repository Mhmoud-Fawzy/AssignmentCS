using System.ComponentModel.DataAnnotations;

namespace Demo.PL.Models.Departments
{
    public class DepartmentViewModel
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;

        [Display (Name = "Creation Date")]
        public DateTime CreationDate { get; set; }
    }
}
