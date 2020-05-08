using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoV.DataAccess.Data
{
    public class StatusProduct
    {
        /// <summary>
        /// Id StatusProduct
        /// </summary>
        public int Id  { get; set; }
        
        /// <summary>
        /// Status (trang thai san pham)
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string status  { get; set; }
        

    }
}