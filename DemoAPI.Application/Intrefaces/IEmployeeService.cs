using DemoAPI.Domain.Entities;

namespace DemoAPI.Application.Intrefaces
{
    public interface IEmployeeService
    {
        Task<IList<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(string Id);
        Task<Employee> AddEmployee(Employee employee);
    }
}
