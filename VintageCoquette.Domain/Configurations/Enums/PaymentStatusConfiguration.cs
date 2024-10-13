using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VintageCoquette.Domain.Configurations.Base;
using VintageCoquette.Domain.Entities.EnumEntities;

namespace VintageCoquette.Domain.Configurations.Enums
{
    public class PaymentStatusConfiguration : BaseEnumConfiguration<PaymentStatus>
    {
        public override void Configure(EntityTypeBuilder<PaymentStatus> builder)
        {
            base.Configure(builder);

            builder.HasMany(paymentStatus => paymentStatus.Payments)
                .WithOne(payment => payment.PaymentStatus)
                .HasForeignKey(payment => payment.PaymentStatusId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
