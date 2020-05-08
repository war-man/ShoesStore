using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace CoV.DataAccess.Data
{
    public class ProductDetails
    {
        public int Id  { get; set; }

        public int SizeProduct { get; set;  }
        
        public  int NumberProduct { get; set; }
        
        /// <summary>
        ///  Image Detail (hinh anh mo ta san pham )
        /// </summary>
        public  string AvatarDetails { get; set; }
        
        /// <summary>
        ///  save Path 
        /// </summary>
        [NotMapped]
        public  IFormFile PhotoPath { get; set; }
        
        public  Product Product { get; set; }
        public  int ProductId { get; set; }

        public StatusProduct StatusProduct { get; set; }
        public int StatusProductId { get; set; }
    }
}