using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.RegularEntities;

namespace VintageCoquette.Domain.Entities.EnumEntities
{
    public record PaymentMethod : BaseEnumEntity
    {
        public static readonly PaymentMethod Online = new PaymentMethod { Id = 1, Name = "Online" };
        public static readonly PaymentMethod PayOnDelivery_Cash = new PaymentMethod { Id = 2, Name = "Pay on Delivery (Cash)" };
        public static readonly PaymentMethod PayOnDelivery_Card = new PaymentMethod { Id = 3, Name = "Pay on Delivery (Card)" };
        public ICollection<Order> Orders { get; set; } // One-to-many relationship with Orders
    }

}
