using Microsoft.AspNetCore.Mvc;
using MongoConnect.Models;
using MongoConnect.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MongoConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet("/Departments/Get")]
        public async Task<IList<Department>> GetDepartmentsAsync()
        {
            return await _departmentRepository.GetAllAsync();
        }

        [HttpGet("/Departments/GetById/{id}")]
        public async Task<Department> GetDepartmentByIdAsync(string id)
        {
            return await _departmentRepository.GetByIdAsync(id);
        }

        [HttpPost("/Departments/Add")]
        public async Task<Department> AddDepartmentAsync(Department department)
        {
            return await _departmentRepository.AddAsync(department);
        }
    }
}
