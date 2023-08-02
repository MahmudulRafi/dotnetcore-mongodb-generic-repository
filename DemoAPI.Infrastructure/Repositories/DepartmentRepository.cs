
using DemoAPI.Domain.Entities;
using DemoAPI.Domain.Interfaces;
using DemoAPI.Infrastructure.Data;
using MongoDB.Driver;

namespace DemoAPI.Infrastructure.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(MongoDbContext mongoDbContext) : base(mongoDbContext)
        {
        }
    }
}

