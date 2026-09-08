namespace EcommerceMarketplace.Models
{
    public class Cart
    {
        public int Id { get; set; }

        // Foreign Key
        public string? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }

        // Navigation Properties
        public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}