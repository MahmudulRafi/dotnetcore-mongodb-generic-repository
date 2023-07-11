using DemoAPI.Core.Entities;
using DemoAPI.Core.Interfaces;
using DemoAPI.Services.Intrefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Services
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
