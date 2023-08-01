
using DemoAPI.Domain.Entities;
using DemoAPI.Domain.Interfaces;
using MongoDB.Driver;

namespace DemoAPI.Infrastructure.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(string connectionString) : base(connectionString)
        {
        }
    }
}

