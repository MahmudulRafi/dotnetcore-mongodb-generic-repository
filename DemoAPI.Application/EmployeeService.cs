using DemoAPI.Domain.Entities;
using DemoAPI.Domain.Interfaces;
using DemoAPI.Application.Intrefaces;

namespace DemoAPI.Application
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            return await _employeeRepository.AddAsync(employee);
        }

        public async Task<Employee> GetEmployeeById(string Id)
        {
            return await _employeeRepository.GetByIdAsync(Id);
        }

        public async Task<IList<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetAllAsync();
        }
    }
}
