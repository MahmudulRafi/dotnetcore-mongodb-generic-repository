using MongoConnect.Models;
using MongoDB.Driver;

namespace MongoConnect.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
