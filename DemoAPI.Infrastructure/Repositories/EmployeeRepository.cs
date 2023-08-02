using DemoAPI.Domain.Interfaces;
using DemoAPI.Domain.Entities;
using MongoDB.Driver;
using DemoAPI.Infrastructure.Data;

namespace DemoAPI.Infrastructure.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(MongoDbContext mongoDbContext) : base(mongoDbContext)
        {
        }
    }
}
