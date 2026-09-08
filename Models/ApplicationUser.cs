using Microsoft.AspNetCore.Identity;

namespace EcommerceMarketplace.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }

        // Navigation Properties
        public virtual Cart? Cart { get; set; }
        public virtual Seller? SellerProfile { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        public virtual ICollection<SellerRequest> SellerRequests { get; set; } = new List<SellerRequest>();
    }
}