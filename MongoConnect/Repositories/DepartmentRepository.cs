using MongoConnect.Models;
using MongoDB.Driver;

namespace MongoConnect.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(string connectionString) : base(connectionString)
        {
        }
    }
}

