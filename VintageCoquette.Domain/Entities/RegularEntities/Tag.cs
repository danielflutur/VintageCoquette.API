using VintageCoquette.Domain.Entities.BaseEntities;
using VintageCoquette.Domain.Entities.JoinedEntities;

namespace VintageCoquette.Domain.Entities.RegularEntities
{
    public record Tag : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; } // Many-to-Many relationship with Product
    }
}
