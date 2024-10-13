using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.RegularEntities;

namespace VintageCoquette.Domain.Entities.EnumEntities
{
    public record GiftOptionType : BaseEnumEntity
    {
        public static readonly GiftOptionType Wrapping = new GiftOptionType { Id = 1, Name = "Gift Wrapping" };
        public static readonly GiftOptionType Message = new GiftOptionType { Id = 2, Name = "Personalized Message" };
        public static readonly GiftOptionType GiftReceipt = new GiftOptionType { Id = 3, Name = "Gift Receipt" };
        public ICollection<GiftOption> OrderGiftOptions { get; set; } // One-to-many relationship with OrderGiftOptions (join entity between Order and GiftOption)
    }
}
