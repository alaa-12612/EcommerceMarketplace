using System;

namespace EcommerceMarketplace.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; } 
        public string? Comment { get; set; }
  
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Foreign Keys
        public string? UserId { get; set; }
       
        public virtual ApplicationUser? User { get; set; }

        public int ProductId { get; set; }
       
        public virtual Product? Product { get; set; }
     
    }
}