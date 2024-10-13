using VintageCoquette.Domain.Entities.RegularEntities;

namespace VintageCoquette.Domain.Entities.JoinedEntities
{
    public record CartItem
    {
        public Guid CartId { get; set; } // Foreign Key to Cart
        public Cart Cart { get; set; }

        public Guid ProductId { get; set; } // Foreign Key to Product
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }

}
