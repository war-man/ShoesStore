using System.Collections.Generic;
using CoV.DataAccess.Data;

namespace CoV.Service.DataModel
{
    public class CategoryProductViewModel
    {
        /// <summary>
        /// key Id of Category Product
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Name of Category Product
        /// </summary>
        public string CategoryName { get; set; }
    }
}