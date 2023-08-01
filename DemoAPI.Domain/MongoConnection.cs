using DemoAPI.Domain.Interfaces;

namespace DemoAPI.Domain
{
    public class MongoConnectionSetting : IMongoConnectionSetting
    {
        public string ConnectionString { get; set; }
    }
}
