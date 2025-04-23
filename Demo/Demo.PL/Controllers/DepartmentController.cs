using AutoMapper;
using Demo.BLL.Models.Departments;
using Demo.BLL.Services.Departments;
using Demo.BLL.Services.Employee;
using Demo.DAL.Models.Departments;
using Demo.PL.Models.Departments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Demo.PL.Controllers
{
	[Authorize]
	// Inheritance: DepartmentController is a Controller
	// Composition: DepartmentController has a IDepartmentService
	public class DepartmentController : Controller
    {
        #region Services

        private readonly IDepartmentService _departmentService;
        private readonly ILogger<DepartmentController> _logger;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;

        public DepartmentController(IDepartmentService departmentService,
                                    ILogger<DepartmentController> logger,
                                    IMapper mapper,
                                    IWebHostEnvironment environment)
        {
            _departmentService = departmentService;
            _logger = logger;
            _mapper = mapper;
            _environment = environment;
        }

        #endregion

        #region Index

        [HttpGet]
        public async Task<IActionResult> Index()   // Get: /Department/Index
        {
            // View's Dictionary: Pass Data from Controller[Action] to view  --> (from view->Partial view, from view->Layout)

            ViewData["Message"] = "Hello ViewData";
            ViewBag.Message = "Hello ViewBag";


            var departments = await _departmentService.GetAllDepartmentsAsync();
            return View(departments);
        }
        #endregion

        #region Details

        [HttpGet]  // Get: /Department/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
                return BadRequest();

            var department = await _departmentService.GetDepartmentByIdAsync(id.Value);

            if (department is null)
                return NotFound();

            return View(department);
        }
        #endregion

        #region Create

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public IActionResult Create()   // Get: /Department/Create
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DepartmentViewModel departmentVM)
        {
            if (!ModelState.IsValid) // Server-Side Validation
                return View(departmentVM);

            var message = string.Empty;

            try
            {
                /// var createdDepartment = new CreatedDepartmentDto()
                /// {
                ///     Code = departmentVM.Code,
                ///     Name = departmentVM.Name,
                ///     Description = departmentVM.Description,
                ///     CreationDate = departmentVM.CreationDate,
                /// };

                var createdDepartment = _mapper.Map<DepartmentViewModel, CreatedDepartmentDto>(departmentVM);
                var Result = await _departmentService.CreateDepartmentAsync(createdDepartment) > 0;

                if (!Result)
                { 
                    message = "Department is not Created";
                    ModelState.AddModelError(string.Empty, message);
                    return View(departmentVM);
                 }

            }
            catch (Exception ex)
            {
                // 1.Log Exception
                _logger.LogError(ex, ex.Message);

                // 2. Set Message
                message = _environment.IsDevelopment() ? ex.Message : "An error has occurred during creating the department :(";

                TempData["Message"] = message;
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Edit

        [HttpGet]  // Get: /Department/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null)
                return BadRequest();  // 400

            var department = await _departmentService.GetDepartmentByIdAsync(id.Value);

            if (department is null)
                return NotFound();  // 404

            var departmentVM = _mapper.Map<DepartmentDetailsToReturnDto, DepartmentViewModel>(department);

            return View(departmentVM);
        }

        [HttpPost]  // Post
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int id, DepartmentViewModel departmentVM)
        {
            if (!ModelState.IsValid)
                return View(departmentVM);

            var message = string.Empty;

            try
            {
                /// var departmentToUpdate = new UpdatedDepartmentDto()
                /// {
                ///     Id = id,
                ///     Code = departmentVM.Code,
                ///     Name = departmentVM.Name,
                ///     Description = departmentVM.Description,
                ///     CreationDate = departmentVM.CreationDate,
                /// };
                /// 

                var departmentToUpdate = _mapper.Map<DepartmentViewModel, UpdatedDepartmentDto>(departmentVM);
                var Update = await _departmentService.UpdateDepartmentAsync(departmentToUpdate) > 0;

                if (Update)
                    return RedirectToAction(nameof(Index));
                message = "An error has occurred during updating the department :(";
            }
            catch (Exception ex)
            {
                // 1.Log Exception
                _logger.LogError(ex, ex.Message);

                // 2. Set Message
                message = _environment.IsDevelopment() ? ex.Message : "An error has occurred during updating the department :(";

            }

            ModelState.AddModelError(string.Empty, message);
            return View(departmentVM);
        }

        #endregion 

        #region Delete

        [HttpGet]  // Get: /Department/Edit
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return BadRequest();  // 400

            var department = await _departmentService.GetDepartmentByIdAsync(id.Value);

            if (department is null)
                return NotFound();  // 404

            return View(department);
        }

        [HttpPost]  // Post
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, [FromServices] IEmployeeService employeeService)
        {
            var message = string.Empty;

            try
            {
                var delete = await _departmentService.DeleteDepartmentAsync(id);
                if (delete)
                {
                    return RedirectToAction(nameof(Index));
                }

                message = "An error has occurred during deleting the department :(";
            }
            catch (Exception ex)
            {
                // 1.Log Exception
                _logger.LogError(ex, ex.Message);

                // 2. Set Message
                message = _environment.IsDevelopment() ? ex.Message : "An error has occurred during deleting the department :(";

            }
            // ModelState.AddModelError(string.Empty, message);
            return RedirectToAction(nameof(Index));
        } 
        #endregion

    }
}
