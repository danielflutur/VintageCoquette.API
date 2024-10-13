﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VintageCoquette.Domain.Entities.BaseEntities;

namespace VintageCoquette.Domain.Configurations.Base
{
    public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(entity => entity.Id);

            builder.Property(entity => entity.IsDeleted)
                .IsRequired();

            builder.Property(entity => entity.CreatedAt)
                .IsRequired();

            builder.Property(entity => entity.UpdatedAt)
                .IsRequired();
        }
    }
}
