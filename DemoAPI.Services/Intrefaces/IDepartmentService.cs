using DemoAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Services.Intrefaces
{
    public interface IDepartmentService
    {
        Task<IList<Department>> GetDepartments();
        Task<Department> GetDepartmentById(string Id);
        Task<Department> AddDepartment(Department department);
    }
}
