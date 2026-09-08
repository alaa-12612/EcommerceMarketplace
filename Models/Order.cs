using System;

namespace EcommerceMarketplace.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Confirmed, Shipped, Delivered, Cancelled[cite: 2]

        // Foreign Key
        public string? UserId { get; set; }
      
        public virtual ApplicationUser? User { get; set; }

        // Navigation Properties
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); 
    }
}