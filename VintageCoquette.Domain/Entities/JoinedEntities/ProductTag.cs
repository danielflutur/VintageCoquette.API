using VintageCoquette.Domain.Entities.RegularEntities;

namespace VintageCoquette.Domain.Entities.JoinedEntities
{
    public record ProductTag
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }

}
