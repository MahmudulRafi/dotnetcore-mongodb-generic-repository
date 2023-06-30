using MongoConnect.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoConnect.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IMongoCollection<Employee> _employees;

        public EmployeeService(IMongoConnectionSetting mongoConnectionSetting, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(mongoConnectionSetting.DatabaseName);
            _employees = database.GetCollection<Employee>(DatabaseCollections.EmployeeCollections);
        }
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _employees.Find(a => true).ToListAsync();
        }
        public async Task<Employee> GetEmployeeByIdAsync(string Id)
        {
            var filter = Builders<Employee>.Filter.Eq("_id", new ObjectId(Id));
            return await _employees.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            await _employees.InsertOneAsync(employee);
            return employee;
        }
    }
}
