using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.EnumEntities;

namespace VintageCoquette.Domain.Entities.RegularEntities
{
    public record Payment : BaseEntity
    {
        public Guid OrderId { get; set; } // Foreign Key to Order
        public Order Order { get; set; }
        public int PaymentMethodId { get; set; } // Enum
        public PaymentMethod PaymentMethod { get; set; } // Enum
        public int PaymentStatusId { get; set; } // Enum
        public PaymentStatus PaymentStatus { get; set; } // Enum
        public string TransactionId { get; set; } // Transaction reference
        public DateTime PaymentDate { get; set; }
    }
}
