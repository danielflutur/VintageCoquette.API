namespace VintageCoquette.Domain.Entities.BaseEntities
{
    public record BaseEnumEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
