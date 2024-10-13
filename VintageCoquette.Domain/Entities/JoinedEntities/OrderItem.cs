using VintageCoquette.Domain.Entities.RegularEntities;

namespace VintageCoquette.Domain.Entities.JoinedEntities
{
    public record OrderItem
    {
        public Guid OrderId { get; set; } // Foreign Key to Order
        public Order Order { get; set; }

        public Guid ProductId { get; set; } // Foreign Key to Product
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

}
