using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Services.Models
{
    public class Order
    {
        Guid Id { get; set; }

        String CustomersName {get; set;}

        int CustomersPhone {get; set;}

        Guid[] ProductsList {get; set;}

        DateTimeOffset PlacingTime { get; set; }

        DateTimeOffset? PostponeDate { get; set; }

        Common.OrderStatuses Status { get; set; }
    }
}
