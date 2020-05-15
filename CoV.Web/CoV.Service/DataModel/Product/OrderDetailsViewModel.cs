using System;
using System.Collections.Generic;
using CoV.DataAccess.Data;

namespace CoV.Service.DataModel
{
    public class OrderDetailsViewModel
    {
        public int  Id { get; set; }
        
        public string NameCustomer { get; set; }

        public string PhoneNumber { get; set; }
        
        public int NumberProduct { get; set; }
        
        public string NameProduct { get; set; }
        
        public string Address { get; set; }
        
        public  int TotalMoney { get; set; }
        
        public DateTime? CreateDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        public string Shipper { get; set; }
        
        public int ProductId { get; set; }
        
        public int Size { get ; set; }
        
        public int Quantity { get; set; }
         
        public int StatusId { get; set; }
        
        public StatusOrder StatusOrder { get; set; }
        public  List<OrderStatusViewModel> StatusModel { get; set; }
    }
}