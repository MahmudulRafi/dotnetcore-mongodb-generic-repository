using DemoAPI.Core.Extensions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DemoAPI.Core.Entities
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
