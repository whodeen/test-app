using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WebApiTest.Models
{
    public class Product
    {
        [BsonId]
        public Guid Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("price")]
        public double Price { get; set; }

        [BsonElement("in_stock")]
        public bool InStock { get; set; }

        [BsonElement("image_link")]
        public string ImageLink { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

    }
}
