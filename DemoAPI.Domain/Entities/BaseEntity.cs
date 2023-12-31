﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DemoAPI.Domain.Entities
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("added_by")]
        public string? AddedBy { get; set; }
        [BsonElement("updated_by")]
        public string? UpdatedBy { get; set; }
        [BsonElement("created_date")]
        public DateTime? CreatedDate { get; set; }
        [BsonElement("updated_date")]
        public DateTime? UpdatedDate { get; set; }
    }
}
