using DemoAPI.Domain.Entities;
using DemoAPI.Domain.Interfaces;
using DemoAPI.Application.Intrefaces;

namespace DemoAPI.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            return await _unitOfWork.Employees.AddAsync(employee);
        }

        public async Task<Employee> GetEmployeeById(string Id)
        {
            return await _unitOfWork.Employees.GetByIdAsync(Id);
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _unitOfWork.Employees.GetAllAsync();
        }
    }
}
