using Demo.BL.DTOs;
using Demo.BL.Factories;
using Demo.BL.Services;
using Demo.DAL.Repos;

public class DepartmentService(IDeptRepo _deptRepo) : IDepartmentService
{
    public IEnumerable<DepartmentDto> GetAllDepartment()
    {
        var departments = _deptRepo.GetAll();
        var ReturnedDepts = departments.Select(d => d.ToDeptDto());
        return ReturnedDepts;
    }

    public DepartmentDetailsDto? GetDepartmentById(int id)
    {
        var department = _deptRepo.GetById(id);
        return department is null ? null : department.DeptDetailsDto();
    }

    public int CreateDepartment(CreateDeptDto createDeptDto)
    {
        var res = _deptRepo.Add(createDeptDto.ToEntity());
        return res;
    }

    public int? UpdateDepartment(CreateDeptDto createDeptDto)
    {
        var res = _deptRepo.Update(createDeptDto.ToEntity());
        return res;
    }
}
