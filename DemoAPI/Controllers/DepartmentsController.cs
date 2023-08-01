using DemoAPI.Domain.Entities;
using DemoAPI.Application.Intrefaces;
using Microsoft.AspNetCore.Mvc;

namespace MongoConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("/Departments/Get")]
        public async Task<IList<Department>> GetDepartmentsAsync()
        {
            return await _departmentService.GetDepartments();
        }

        [HttpGet("/Departments/GetById/{id}")]
        public async Task<Department> GetDepartmentByIdAsync(string id)
        {
            return await _departmentService.GetDepartmentById(id);
        }

        [HttpPost("/Departments/Add")]
        public async Task<Department> AddDepartmentAsync(Department department)
        {
            return await _departmentService.AddDepartment(department);
        }
    }
}
