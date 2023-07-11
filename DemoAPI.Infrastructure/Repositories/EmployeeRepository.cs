using DemoAPI.Core.Interfaces;
using DemoAPI.Core.Entities;
using MongoDB.Driver;

namespace DemoAPI.Infrastructure.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
