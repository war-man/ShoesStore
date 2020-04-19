using System.Collections.Generic;
using CoV.DataAccess.Data;

namespace CoV.Service.Service
{
    public class Oder_Detail
    {
        public int Id  { get; set; }
        
        public ICollection<Cart> Cart { get; set; } 
    }
}