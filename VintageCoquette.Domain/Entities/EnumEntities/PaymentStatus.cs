using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.RegularEntities;

namespace VintageCoquette.Domain.Entities.EnumEntities
{
    public record PaymentStatus : BaseEnumEntity
    {
        public static readonly PaymentStatus Success = new PaymentStatus { Id = 1, Name = "Success" };
        public static readonly PaymentStatus Pending = new PaymentStatus { Id = 2, Name = "Pending" };
        public static readonly PaymentStatus Failed = new PaymentStatus { Id = 3, Name = "Failed" };
        public static readonly PaymentStatus Collected = new PaymentStatus { Id = 4, Name = "Collected" };
        public ICollection<Payment> Payments { get; set; } // One-to-many relationship with Payments
    }
}
