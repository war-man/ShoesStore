using CoV.DataAccess.Data;

namespace CoV.Service.DataModel
{
    public class CartViewModel
    {
        public int Id { get; set; }
        
        public  string Name { get; set; }
        
        public int Quantity { get; set; }
        
        public int ProductId { get; set; }
        
        public ProductViewModel Product { get; set; }
    }
}