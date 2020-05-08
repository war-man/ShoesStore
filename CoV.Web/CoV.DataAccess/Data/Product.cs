using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoV.DataAccess.Data
{
    public class Product
    {
        /// <summary>
        /// Id Product
        /// </summary>
        public  int Id { get; set; }
        
        /// <summary>
        /// Name Product 
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public  string Name { get; set; }
        
        /// <summary>
        /// Code Product (Ma san pham)
        /// </summary>
        [Column(TypeName = "nvarchar(30)")]
        public  string Sku  { get; set; }
        
        /// <summary>
        /// price product 
        /// </summary>
        public int  Price { get; set; }
        
        /// <summary>
        /// price product 
        /// </summary>
        public int  PriceNew { get; set; }
        /// <summary>
        ///  date of import (Ngay nhap hang hoa )
        /// </summary>
        public  DateTime FirstDate { get; set; }
        
        /// <summary>
        ///  Image Detail (hinh anh mo ta san pham )
        /// </summary>
        public  string AvatarDetails { get; set; }

        /// <summary>
        /// Details Product (Mo ta san pham )
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public  string Details { get; set; }
        
        /// <summary>
        /// Id table Image ForeignKey (the loai san pam)
        /// </summary>
        public int CategoryProductId  { get; set; }
        [ForeignKey("CategoryProductId")]
        public CategoryProduct CategoryProduct { get; set; }
        
        /// <summary>
        /// id GenderProduct (gio tinh)
        /// </summary>
        public  int GenderProductId { get; set; }
        [ForeignKey("GenderProductId")]
        public  Gender Gender { get; set; }
        
        /// <summary>
        /// id GenderProduct (hang san xuat )
        /// </summary>
        public  int MakerProductId  { get; set; }
        [ForeignKey("MakerProductId")]
        public  MakerProduct MakerProduct { get; set; }
    }
}