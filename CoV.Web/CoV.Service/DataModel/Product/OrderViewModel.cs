using System;
using System.Collections.Generic;
using CoV.DataAccess.Data;

namespace CoV.Service.DataModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        
        public  string Name { get; set; }
        
        public int Quantity { get; set; }
        
        public int ProductId { get; set; }
        
        public int TotalPrice { get; set; } 
        
        public int Size { get; set; } 
        
        public  string ShipCode { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public ProductViewModel Product { get; set; }
        
        public int StatusId { get; set; }
        
        public StatusOrder StatusOrder { get; set; }
        public  List<OrderStatusViewModel> StatusModel { get; set; }

    }
}