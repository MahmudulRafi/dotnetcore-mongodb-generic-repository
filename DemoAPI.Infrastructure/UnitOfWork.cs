using DemoAPI.Domain.Interfaces;
using DemoAPI.Infrastructure.Data;
using DemoAPI.Infrastructure.Repositories;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private MongoDbContext _mongoDbContext;
        public IEmployeeRepository Employees => new EmployeeRepository(_mongoDbContext);
        public IDepartmentRepository Departments => new DepartmentRepository(_mongoDbContext);
        public UnitOfWork(MongoDbContext mongoDbContext)
        {
            _mongoDbContext = mongoDbContext;
        }
        public void Commit()
        {
        }

        public void Dispose()
        {
        }

        public void Rollback()
        {
        }
    }
}
