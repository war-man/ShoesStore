namespace CoV.Service.DataModel
{
    public class CartViewModel
    {
        public int Id { get; set; }
        
        public  string Name { get; set; }
        
        public int Quantity { get; set; }
        
        public int ProductId { get; set; }
        
        public int TotalPrice { get; set; } 
        
        public int Size { get; set; } 
        
        public ProductViewModel Product { get; set; }
    }
}