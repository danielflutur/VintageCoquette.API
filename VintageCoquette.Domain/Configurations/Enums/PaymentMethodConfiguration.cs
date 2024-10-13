using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VintageCoquette.Domain.Configurations.Base;
using VintageCoquette.Domain.Entities.EnumEntities;

namespace VintageCoquette.Domain.Configurations.Enums
{
    public class PaymentMethodConfiguration : BaseEnumConfiguration<PaymentMethod>
    {
        public override void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            base.Configure(builder);

            builder.HasMany(paymentMethod => paymentMethod.Orders)
                .WithOne(order => order.PaymentMethod)
                .HasForeignKey(order => order.PaymentMethodId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

}
