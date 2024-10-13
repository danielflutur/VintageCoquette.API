using VintageCoquette.Domain.Entities.BaseEntities;

namespace VintageCoquette.Domain.Entities.RegularEntities
{
    public record DiscountCode : BaseEntity
    {
        public string Code { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
    }
}
