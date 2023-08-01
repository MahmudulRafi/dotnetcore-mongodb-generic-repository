using DemoAPI.Domain.Entities;
using DemoAPI.Domain.Interfaces;
using DemoAPI.Application.Intrefaces;

namespace DemoAPI.Application
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
