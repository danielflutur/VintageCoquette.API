using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VintageCoquette.Domain.Configurations.Base;
using VintageCoquette.Domain.Entities.EnumEntities;

namespace VintageCoquette.Domain.Configurations.Enums
{
    public class OrderStatusConfiguration : BaseEnumConfiguration<OrderStatus>
    {
        public override void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            base.Configure(builder);

            builder.HasMany(orderStatus => orderStatus.Orders)
                .WithOne(order => order.OrderStatus)
                .HasForeignKey(order => order.OrderStatusId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
