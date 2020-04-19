using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoV.DataAccess.Data
{
    public class Cart
    {
        public int Id { get; set; }
        
        public int Quantity { get; set; }
        
        public int ProductId { get; set; }
        
        public Product Product { get; set; }

    }
}