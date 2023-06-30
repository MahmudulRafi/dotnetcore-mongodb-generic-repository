using MongoConnect.Extensions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoConnect.Models
{
    [BsonCollection("Departments")]
    [BsonDatabase("EmployeeDB")]
    [BsonIgnoreExtraElements]
    public class Department : BaseEntity
    {
        [BsonElement("name")]
        public string? Name { get; set; }
    }
}
