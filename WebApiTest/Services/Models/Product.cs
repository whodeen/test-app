
using System;

namespace Services.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool InStock { get; set; }

        public string ImageLink { get; set; }

        public string Description { get; set; }

    }
}
