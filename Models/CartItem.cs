namespace EcommerceMarketplace.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
       

        // Foreign Keys
        public int CartId { get; set; }
        public virtual Cart? Cart { get; set; }

        public int ProductId { get; set; }
       
        public virtual Product? Product { get; set; }
       
    }
}