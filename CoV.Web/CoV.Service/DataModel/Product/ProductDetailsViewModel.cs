using Microsoft.AspNetCore.Http;

namespace CoV.Service.DataModel
{
    public class ProductDetailsViewModel
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
        public  IFormFile PhotoPath { get; set; }
        
        public  ProductViewModel Product { get; set; }
        public  int ProductId { get; set; }

        public StatusProductViewModel StatusProduct { get; set; }
        public int StatusProductId { get; set; }
        
    }
}