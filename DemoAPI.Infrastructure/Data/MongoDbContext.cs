using MongoDB.Driver;

namespace DemoAPI.Infrastructure.Data
{
    public class MongoDbContext
    {
        private IMongoClient _mongoClient;
        public MongoDbContext(string connectionString)
        {
            _mongoClient = new MongoClient(connectionString);
        }
        public IMongoDatabase GetDatabase(string databaseName)
        {
            return _mongoClient.GetDatabase(databaseName);
        }
    }
}
