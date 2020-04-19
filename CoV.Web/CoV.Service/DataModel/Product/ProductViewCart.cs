using System;

namespace CoV.Service.DataModel
{
    public class ProductViewCart
    {
        /// <summary>
        /// Id Product
        /// </summary>
        public  int Id { get; set; }
        
        /// <summary>
        /// Name Product 
        /// </summary>
        public  string name { get; set; }
        
        /// <summary>
        /// Code Product (Ma san pham)
        /// </summary>
        public  string Sku  { get; set; }
        
        /// <summary>
        /// price product 
        /// </summary>
        public int  Price { get; set; }
        
        /// <summary>
        ///  date of import (Ngay nhap hang hoa )
        /// </summary>
        public  DateTime FirstDate { get; set; }

        /// <summary>
        /// Details Product (Mo ta san pham )
        /// </summary>
        public  string Details { get; set; }
        
        /// <summary>
        /// Address produc (Noi san xuat cua san pham )
        /// </summary>
        public  string  AddressProduction { get; set; }
        
        /// <summary>
        ///  Image Detail (hinh anh mo ta san pham )
        /// </summary>
        public  string AvatarDetails { get; set; }
        
        /// <summary>
        /// Number Product (so luong san pham )
        /// </summary>
        public int  Number { get; set; }
        
        /// <summary>
        /// Id table ColorProduct ForeignKey
        /// </summary>
        public string ColorProductId { get; set; }
 

        
        /// <summary>
        /// Id table SizeProduct ForeignKey
        /// </summary>
        public string MakerProductId { get; set; }
        

        
        /// <summary>
        /// Id table StatusProduct ForeignKey
        /// </summary>
        public string StatusProductId { get; set; }


        /// <summary>
        /// Id table Image ForeignKey
        /// </summary>
        public string ImageId  { get; set; }
        
        /// <summary>
        /// Id table Image ForeignKey
        /// </summary>
        public string CategoryProductId  { get; set; }
        
        /// <summary>
        /// id GenderProduct
        /// </summary>
        public  string GenderProductId { get; set; }

    }
}