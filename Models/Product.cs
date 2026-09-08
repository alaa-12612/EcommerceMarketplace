namespace EcommerceMarketplace.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
      
        public string? Description { get; set; }
      
        public decimal Price { get; set; }
       
        public int AvailableQuantity { get; set; }
     
        public string? ImageUrl { get; set; }
       

        // Foreign Keys
        public int CategoryId { get; set; }
     
        public virtual Category? Category { get; set; }
      

        public int SellerId { get; set; }
      
        public virtual Seller? Seller { get; set; }
      

        // Navigation Properties
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public virtual ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
    }
}