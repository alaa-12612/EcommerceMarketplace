using System;

namespace EcommerceMarketplace.Models
{
    public class SellerRequest
    {
        public int Id { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected
        public DateTime RequestDate { get; set; } = DateTime.Now;

        // Foreign Key
        public string? UserId { get; set; }
      
        public virtual ApplicationUser? User { get; set; }
    }
}