using System.Collections.Generic;

namespace CoV.DataAccess.Data
{
    public class CategoryProduct
    {
        /// <summary>
        /// key Id of Category Product
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Name of Category Product
        /// </summary>
        public string CategoryName { get; set; }
        
        public  ICollection<Product> CatogoryProducts { get; set; }
    }
}