using MongoConnect.Models;

namespace MongoConnect.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(string id);
        Task<Employee> AddEmployeeAsync(Employee employee);
    }
}
