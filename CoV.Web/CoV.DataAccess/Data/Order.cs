using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoV.DataAccess.Data
{
    public class Order
    {
        public int Id { get; set; }
        
        public  string Name { get; set; }
        
        public int Quantity { get; set; }
        
        public int ProductId { get; set; }
        
        public int TotalPrice { get; set; } 
        
        public int Size { get; set; } 
        
        public DateTime CreateDate { get; set; }
        
        public Product Product { get; set; }
        
        public int StatusId { get ; set; }
        [ForeignKey("StatusId")]
        public StatusOrder StatusOrder { get; set; }
    }
}