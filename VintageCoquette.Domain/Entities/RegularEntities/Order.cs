using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.EnumEntities;
using VintageCoquette.Domain.Entities.JoinedEntities;

namespace VintageCoquette.Domain.Entities.RegularEntities
{
    public record Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int OrderTotal { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; } // Enum
        public int PaymentMethodId { get; set; } // Enum
        public PaymentMethod PaymentMethod { get; set; } // Enum
        public int PaymentStatusId { get; set; } // Enum
        public PaymentStatus PaymentStatus { get; set; } // Enum
        public ICollection<OrderItem> OrderItems { get; set; } // One-to-Many relationship with OrderItem
        public Guid? GiftOptionId { get; set; } // Foreign Key to GiftOption (optional)
        public GiftOption GiftOption { get; set; }
        public Guid? DiscountCodeId { get; set; } // Foreign Key to DiscountCode (optional)
        public DiscountCode DiscountCode { get; set; }
    }
}
