﻿using DemoAPI.Domain.Entities;

namespace DemoAPI.Application.Intrefaces
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetDepartments();
        Task<Department> GetDepartmentById(string Id);
        Task<Department> AddDepartment(Department department);
    }
}
