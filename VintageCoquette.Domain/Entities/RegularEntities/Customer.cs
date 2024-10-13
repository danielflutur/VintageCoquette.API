using VintageCoquette.Domain.Entities.BaseEntities;

namespace VintageCoquette.Domain.Entities.RegularEntities
{
    public record Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Order> Orders { get; set; } // One-to-Many relationship with Order
    }
}
