using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.EnumEntities;
using VintageCoquette.Domain.Entities.JoinedEntities;

namespace VintageCoquette.Domain.Entities.RegularEntities
{
    public record Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public Guid CategoryId { get; set; } // Foreign Key to Category
        public ProductCategory Category { get; set; }
        public bool IsFeatured { get; set; } // Flag for featured products
        public List<string> ImageUrls { get; set; } // Could be a JSON or separate entity for images
        public ICollection<ProductTag> ProductTags { get; set; } // Many-to-Many relationship with Tags
    }
}
