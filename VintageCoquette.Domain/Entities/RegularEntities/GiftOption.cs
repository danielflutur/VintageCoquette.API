using VintageCoquette.Domain.Entities.BaseEntities;

namespace VintageCoquette.Domain.Entities.RegularEntities
{
    public record GiftOption : BaseEntity
    {
        public string GiftMessage { get; set; }
        public bool IsGiftWrapped { get; set; }
        public bool IsGiftReceipt { get; set; }
    }
}
