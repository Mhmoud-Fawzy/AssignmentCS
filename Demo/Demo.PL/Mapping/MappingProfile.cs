using AutoMapper;
using Demo.BLL.Models.Departments;
using Demo.BLL.Models.Employees;
using Demo.PL.Models.Departments;
using Demo.PL.Models.Employees;

namespace Demo.PL.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            #region Employee

            CreateMap<EmployeeDetailsToReturnDto, EmployeeViewModel>();

            CreateMap<EmployeeViewModel, UpdatedEmployeeDto>();
            CreateMap<EmployeeViewModel, CreatedEmployeeDto>();

            #endregion

            #region Department

            CreateMap<DepartmentDetailsToReturnDto, DepartmentViewModel>()
                /*.ForMember(dest => dest.Name, config => config.MapFrom(src => src.Name))*/

                /*.ReverseMap()*/
                /*.ForMember(dest => dest.Name, config => config.MapFrom(src => src.Name))*/;
            CreateMap<DepartmentViewModel,UpdatedDepartmentDto>() ;
            CreateMap<DepartmentViewModel, CreatedDepartmentDto>();

            #endregion
        }

    }
}
