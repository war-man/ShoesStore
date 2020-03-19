using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoV.DataAccess.Data
{
    public class Gender
    {
        /// <summary>
        /// Gender 
        /// </summaryId>
        public int Id  { get; set; }
        
        /// <summary>
        /// Gender N
        /// </summary>ame
        [Column(TypeName = "nvarchar(30)")]
        public string GenderName  { get; set; }
        
        public ICollection<Product> GenderProduct { get; set; }
    }
}