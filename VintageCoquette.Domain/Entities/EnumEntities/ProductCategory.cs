using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.RegularEntities;

namespace VintageCoquette.Domain.Entities.EnumEntities
{
    public record ProductCategory : BaseEnumEntity
    {
        public static readonly ProductCategory Rings = new ProductCategory { Id = 1, Name = "Rings" };
        public static readonly ProductCategory Necklaces = new ProductCategory { Id = 2, Name = "Necklaces" };
        public static readonly ProductCategory Earrings = new ProductCategory { Id = 3, Name = "Earrings" };
        public static readonly ProductCategory Bracelets = new ProductCategory { Id = 4, Name = "Bracelets" };
        public static readonly ProductCategory Scarfs = new ProductCategory { Id = 4, Name = "Scarfs" };
        public static readonly ProductCategory Bags = new ProductCategory { Id = 4, Name = "Bags" };
        public ICollection<Product> Products { get; set; } // One-to-many relationship with Products
    }
}
