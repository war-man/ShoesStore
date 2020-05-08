using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoV.DataAccess.Data
{
    public class ColorProduct
    {
        /// <summary>
        /// Id ColorProduct
        /// </summary>
        public int Id  { get; set; }
        
        /// <summary>
        /// Color Product (mau sac cua san pham )
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Color  { get; set; }
        
    }
}