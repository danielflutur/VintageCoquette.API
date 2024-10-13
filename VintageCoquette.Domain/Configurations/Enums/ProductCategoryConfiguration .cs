using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VintageCoquette.Domain.Configurations.Base;
using VintageCoquette.Domain.Entities.EnumEntities;

namespace VintageCoquette.Domain.Configurations.Enums
{
    public class ProductCategoryConfiguration : BaseEnumConfiguration<ProductCategory>
    {
        public override void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            base.Configure(builder);

            builder.HasMany(category => category.Products)
                .WithOne(product => product.Category)
                .HasForeignKey(product => product.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
