using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoConnect.Models;
using MongoConnect.Repositories;

namespace MongoConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("/Employees/Get")]
        public async Task<IList<Employee>> GetEmployeesAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }
        [HttpGet("/Employees/GetById/{id}")]
        public async Task<IActionResult> GetEmployeeByIdAsync(string id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee is null)
                return NotFound("Employee Not Found");
            return Ok(employee);
        }

        [HttpPost("/Employees/AddEmployee")]
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            return await _employeeRepository.AddAsync(employee);
        }

    }
}
