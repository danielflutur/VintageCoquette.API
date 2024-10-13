using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.RegularEntities;

namespace VintageCoquette.Domain.Entities.EnumEntities
{
    public record DiscountType : BaseEnumEntity
    {
        public static readonly DiscountType Percentage = new DiscountType { Id = 1, Name = "Percentage" };
        public static readonly DiscountType FixedAmount = new DiscountType { Id = 2, Name = "Fixed Amount" };
        public ICollection<DiscountCode> Discounts { get; set; } // One-to-many relationship with Discounts
    }
}
}
