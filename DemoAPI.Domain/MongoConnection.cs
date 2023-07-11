using DemoAPI.Core.Interfaces;

namespace DemoAPI.Core
{
    public class MongoConnectionSetting : IMongoConnectionSetting
    {
        public string ConnectionString { get; set; }
    }
}
