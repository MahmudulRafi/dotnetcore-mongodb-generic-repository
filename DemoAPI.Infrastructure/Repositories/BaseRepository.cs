using DemoAPI.Domain.Entities;
using DemoAPI.Domain.Extensions;
using DemoAPI.Domain.Interfaces;
using DemoAPI.Infrastructure.Data;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DemoAPI.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly IMongoCollection<T> _collection;
        public BaseRepository(MongoDbContext mongoDbContext)
        {
            var mongoDatabaseBase = mongoDbContext.GetDatabase(GetDatabaseName(typeof(T)));
            _collection = mongoDatabaseBase.GetCollection<T>(GetCollectionName(typeof(T)));
        }
        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType
                   .GetCustomAttributes(typeof(BsonCollectionAttribute), true)
                   .FirstOrDefault())?.CollectionName;
        }
        private protected string GetDatabaseName(Type documentType)
        {
            return ((BsonDatabaseAttribute)documentType
                   .GetCustomAttributes(typeof(BsonDatabaseAttribute), true)
                   .FirstOrDefault())?.DatabaseName;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _collection.Find(a => true).ToListAsync();
        }

        public async Task<T> GetByIdAsync(string Id)
        {
            var filter = Builders<T>.Filter.Eq("_id", new ObjectId(Id));
            return await _collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<T> AddAsync(T document)
        {
            document.CreatedDate = DateTime.Now;
            await _collection.InsertOneAsync(document);
            return document;
        }
    }
}
