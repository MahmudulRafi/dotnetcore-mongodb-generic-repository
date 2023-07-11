
using DemoAPI.Core.Entities;
using DemoAPI.Core.Interfaces;
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

