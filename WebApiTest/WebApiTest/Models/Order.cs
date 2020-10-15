using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WebApiTest.Models
{
    public class Order
    {
        [BsonId]
        Guid Id { get; set; }

        [BsonElement("customers_name")]
        String CustomersName {get; set;}

        [BsonElement("customers_phone")]
        int CustomersPhone {get; set;}

        [BsonElement("products_ids")]
        Guid[] ProductsList {get; set;}

        [BsonElement("placing_time")]
        DateTimeOffset PlacingTime { get; set; }

        [BsonElement("postpone_date")]
        DateTimeOffset? PostponeDate { get; set; }

        [BsonElement("status")]
        Common.OrderStatuses Status { get; set; }
    }
}
