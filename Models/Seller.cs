namespace EcommerceMarketplace.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public bool IsApproved { get; set; } = false;

        // Foreign Key to ApplicationUser
        public string? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        // Navigation Properties
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}