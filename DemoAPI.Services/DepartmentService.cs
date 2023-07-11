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
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<Department> AddDepartment(Department department)
        {
            return await _departmentRepository.AddAsync(department);
        }

        public async Task<Department> GetDepartmentById(string Id)
        {
            return await _departmentRepository.GetByIdAsync(Id);
        }

        public async Task<IList<Department>> GetDepartments()
        {
            return await _departmentRepository.GetAllAsync();
        }
    }
}
