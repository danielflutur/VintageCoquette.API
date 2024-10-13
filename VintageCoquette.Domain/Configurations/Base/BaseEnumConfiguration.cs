using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VintageCoquette.Domain.Entities.BaseEntities;

namespace VintageCoquette.Domain.Configurations.Base
{
    public class BaseEnumConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEnumEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(entity => entity.Id);

            builder.Property(entity => entity.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(entity => entity.Name);
        }
    }
}
