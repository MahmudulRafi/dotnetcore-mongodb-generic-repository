using MongoConnect.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoConnect.Services
{
    public class DepartmentService : IDepartmentService
    {
        private IMongoCollection<Department> _departments;

        public DepartmentService(IMongoConnectionSetting mongoConnectionSetting, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(mongoConnectionSetting.DatabaseName);
            _departments = database.GetCollection<Department>(DatabaseCollections.DepartmentCollections);
        }
        public List<Department> GetDepartments()
        {
            return _departments.Find(a => true).ToList();
        }

        public Department GetDepartmentById(string Id)
        {
            var filter = Builders<Department>.Filter.Eq("_id", new ObjectId(Id));
            return _departments.Find(filter).FirstOrDefault();
        }

    }
}
