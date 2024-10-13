using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.JoinedEntities;

namespace VintageCoquette.Domain.Entities.RegularEntities
{
    public record Cart : BaseEntity
    {
        public Guid CustomerId { get; set; } // Foreign Key to Customer
        public Customer Customer { get; set; }
        public ICollection<CartItem> CartItems { get; set; } // One-to-Many relationship with CartItem
    }
}
