using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoV.DataAccess.Data
{
    public class StatusOrder
    {
        public int  Id { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Status  { get; set; }
        
        public  ICollection<Order> Orders { get; set; }
        public  ICollection<OrderDetals> Detalses { get; set; }
        
    }
}