using System.Collections.Generic;

namespace CoV.DataAccess.Data
{
    public class MakerProduct
    {
        /// <summary>
        /// Id Table s
        /// </summary>izeProduc
        public int Id  { get; set; } 
        
        /// <summary>
        /// Size Product 
        /// </summary>
        public string MakerName  { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public ICollection<Product> MakerProducts  { get; set; }
    }
}