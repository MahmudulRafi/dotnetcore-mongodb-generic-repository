using DemoAPI.Domain.Entities;
using DemoAPI.Application.Intrefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MongoConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("/Employees/Get")]
        public async Task<IList<Employee>> GetEmployeesAsync()
        {
            return await _employeeService.GetEmployees();
        }
        [HttpGet("/Employees/GetById/{id}")]
        public async Task<IActionResult> GetEmployeeByIdAsync(string id)
        {
            var employee = await _employeeService.GetEmployeeById(id);
            if (employee is null)
                return NotFound("Employee Not Found");
            return Ok(employee);
        }

        [HttpPost("/Employees/AddEmployee")]
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            return await _employeeService.AddEmployee(employee);
        }

    }
}
