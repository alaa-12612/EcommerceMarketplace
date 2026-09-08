namespace EcommerceMarketplace.Models
{
    public class WishlistItem
    {
        public int Id { get; set; }

        // Foreign Keys
        public string? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }

        public int ProductId { get; set; }

        public virtual Product? Product { get; set; }
    }
}