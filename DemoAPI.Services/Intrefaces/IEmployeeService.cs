using DemoAPI.Core;
using DemoAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Services.Intrefaces
{
    public interface IEmployeeService
    {
        Task<IList<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(string Id);
        Task<Employee> AddEmployee(Employee employee);
    }
}
