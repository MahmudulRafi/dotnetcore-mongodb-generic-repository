using MongoDB.Bson.Serialization.Attributes;

namespace DemoAPI.Domain.Entities
{
    public class Address
    {
        [BsonElement("permanent_address")]
        public string PermanentAddress { get; set; }
        [BsonElement("present_address")]
        public string PresentAddress { get; set; }
    }
}
