using MongoDB.Bson.Serialization.Attributes;

namespace MongoConnect.Models
{
    public class Address
    {
        [BsonElement("permanent_address")]
        public string PermanentAddress { get; set; }
        [BsonElement("present_address")]
        public string PresentAddress { get; set; }
    }
}
