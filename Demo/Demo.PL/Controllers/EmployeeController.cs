using AutoMapper;
using Demo.BLL.Models.Employees;
using Demo.BLL.Services.Employee;
using Demo.PL.Models.Employees;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
	[Authorize]
	public class EmployeeController : Controller
    {
        #region Services

        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;

        public EmployeeController(IEmployeeService employeeService,
                                  ILogger<EmployeeController> logger,
                                  IMapper mapper,
                                  IWebHostEnvironment environment)
        {
            _employeeService = employeeService;
            _logger = logger;
            _mapper = mapper;
            _environment = environment; 
        }

        #endregion

        #region Index

        [HttpGet]
        public async Task<IActionResult> Index(string search)   // Get: /Employee/Index
        {
            var employees = await _employeeService.GetAllEmployeesAsync(search);

            //if (!string.IsNullOrEmpty(search))
            //    return PartialView("Partials/_EmployeeListPartial", employees);

            return View(employees);
        }

        #endregion

        #region Details

        [HttpGet]  // Get: /Employee/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
                return BadRequest();

            var employee = await _employeeService.GetEmployeeByIdAsync(id.Value);

            if (employee is null)
                return NotFound();

            return View(employee);
        }

        #endregion

        #region Create

        [HttpGet]

		public IActionResult Create()   // Get: /Employee/Create
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel employee)
        {
            if (!ModelState.IsValid) // Server-Side Validation
                return View(employee);

            var message = string.Empty;

            try
            {
                 /// var createdEmployee = new CreatedEmployeeDto()
                 /// {
                 ///     Name = employee.Name,
                 ///     Age = employee.Age,
                 ///     Address = employee.Address,
                 ///     Salary = employee.Salary,
                 ///     IsActive = employee.IsActive,
                 ///     PhoneNumber = employee.PhoneNumber,
                 ///     Email = employee.Email,
                 ///     HiringDate = employee.HiringDate,
                 ///     Gender = employee.Gender,
                 ///     Image= employee.Image,
                 ///     EmployeeType = employee.EmployeeType,
                 ///     DepartmentId = employee.DepartmentId,
                 /// };

                var createdEmployee = _mapper.Map<EmployeeViewModel, CreatedEmployeeDto>(employee);

                var Result = await _employeeService.CreateEmployeeAsync(createdEmployee);
                if (Result > 0)
                    return RedirectToAction(nameof(Index));
                else
                {
                    message = "Employee is not Created";
                    ModelState.AddModelError(string.Empty, message);
                    return View(Result);
                }
            }
            catch (Exception ex)
            {
                // 1.Log Exception
                _logger.LogError(ex, ex.Message);

                // 2. Set Message
                message = _environment.IsDevelopment() ? ex.Message : "An error has occurred during creating the Employee :(";
            }

            ModelState.AddModelError(string.Empty, message);
            return View(employee);
        }

        #endregion

        #region Edit

        [HttpGet]  // Get: /Employee/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null)
                return BadRequest();  // 400

            var employee = await _employeeService.GetEmployeeByIdAsync(id.Value);

            if (employee is null)
                return NotFound();  // 404

            var employeeNM = _mapper.Map<EmployeeDetailsToReturnDto, EmployeeViewModel>(employee);

            return View(employeeNM);
        }

        [HttpPost]  // Post
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int id, EmployeeViewModel employee)
        {
            if (!ModelState.IsValid)
                return View(employee);
            
            var message = string.Empty;

            try
            {
                /// var UpdatedEmployee = new UpdatedEmployeeDto()
                /// {
                ///     Id=employee.Id,
                ///     Name = employee.Name,
                ///     Age = employee.Age,
                ///     Address = employee.Address,
                ///     Salary = employee.Salary,
                ///     IsActive = employee.IsActive,
                ///     PhoneNumber = employee.PhoneNumber,
                ///     Email = employee.Email,
                ///     HiringDate = employee.HiringDate,
                ///     Gender = employee.Gender,
                ///     EmployeeType = employee.EmployeeType,
                ///     DepartmentId = employee.DepartmentId,
                /// };

                var UpdatedEmployee = _mapper.Map<EmployeeViewModel, UpdatedEmployeeDto>(employee);
                var Update = await _employeeService.UpdateEmployeeAsync(UpdatedEmployee) > 0;

                if (Update)
                    return RedirectToAction(nameof(Index));
                message = "An error has occurred during updating the employee :(";
            }
            catch (Exception ex)
            {
                // 1.Log Exception
                _logger.LogError(ex, ex.Message);

                // 2. Set Message
                message = _environment.IsDevelopment() ? ex.Message : "An error has occurred during updating the employee :(";

            }

            ModelState.AddModelError(string.Empty, message);
            return View(employee);
        }
        #endregion

        #region Delete

        [HttpPost]  // Post
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var message = string.Empty;

            try
            {
                var delete = await _employeeService.DeleteEmployeeAsync(id);
                if (delete)
                {
                    return RedirectToAction(nameof(Index));
                 
                }

                message = "An error has occurred during deleting the employee :(";
            }
            catch (Exception ex)
            {
                // 1.Log Exception
                _logger.LogError(ex, ex.Message);

                // 2. Set Message
                message = _environment.IsDevelopment() ? ex.Message : "An error has occurred during deleting the employee :(";

            }
            // ModelState.AddModelError(string.Empty, message);
            return RedirectToAction(nameof(Index));
        }

        #endregion
    }
}
