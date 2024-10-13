using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.RegularEntities;

namespace VintageCoquette.Domain.Entities.EnumEntities
{
    public record OrderStatus : BaseEnumEntity
    {
        public static readonly OrderStatus Pending = new OrderStatus { Id = 1, Name = "Pending" };
        public static readonly OrderStatus Shipped = new OrderStatus { Id = 2, Name = "Shipped" };
        public static readonly OrderStatus Delivered = new OrderStatus { Id = 3, Name = "Delivered" };
        public static readonly OrderStatus Canceled = new OrderStatus { Id = 4, Name = "Canceled" };
        public ICollection<Order> Orders { get; set; } // One-to-many relationship with Orders
    }
}
