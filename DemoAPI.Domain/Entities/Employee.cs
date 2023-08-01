
using DemoAPI.Domain.Extensions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DemoAPI.Domain.Entities
{
    [BsonCollection("Employees")]
    [BsonDatabase("EmployeeDB")]
    [BsonIgnoreExtraElements]
    public class Employee : BaseEntity
    {
        public Employee()
        {
            Addresses = new List<Address>();
        }
        [BsonElement("name")]
        public string? Name { get; set; }
        [BsonElement("email")]
        public string? Email { get; set; }
        [BsonElement("address")]
        public List<Address> Addresses { get; set; }
    }
}
