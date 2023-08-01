using DemoAPI.Domain.Extensions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DemoAPI.Domain.Entities
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
