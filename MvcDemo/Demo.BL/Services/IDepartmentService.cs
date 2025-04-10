using Demo.BL.DTOs;

namespace Demo.BL.Services
{
    public interface IDepartmentService
    {
        int CreateDepartment(CreateDeptDto createDeptDto);
        IEnumerable<DepartmentDto> GetAllDepartment();
        DepartmentDetailsDto? GetDepartmentById(int id);
        int? UpdateDepartment(CreateDeptDto createDeptDto);
    }
}