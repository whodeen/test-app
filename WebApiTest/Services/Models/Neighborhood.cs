using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WebApiTest.Models
{
    [BsonIgnoreExtraElements]
    public class Neighborhood
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public String Name { get; set; }
        
        [BsonElement("geometry")]
        public Object Geometry { get; set; }
    }
}
