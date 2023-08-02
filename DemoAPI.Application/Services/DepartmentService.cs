using DemoAPI.Domain.Entities;
using DemoAPI.Domain.Interfaces;
using DemoAPI.Application.Intrefaces;

namespace DemoAPI.Application.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Department> AddDepartment(Department department)
        {
            return await _unitOfWork.Departments.AddAsync(department);
        }

        public async Task<Department> GetDepartmentById(string Id)
        {
            return await _unitOfWork.Departments.GetByIdAsync(Id);
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await _unitOfWork.Departments.GetAllAsync();
        }
    }
}
