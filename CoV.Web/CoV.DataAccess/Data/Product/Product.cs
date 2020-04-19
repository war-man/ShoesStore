using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

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
        public  string name { get; set; }
        
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
        ///  date of import (Ngay nhap hang hoa )
        /// </summary>
        public  DateTime FirstDate { get; set; }

        /// <summary>
        /// Details Product (Mo ta san pham )
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public  string Details { get; set; }
        
        /// <summary>
        /// Address produc (Noi san xuat cua san pham )
        /// </summary>
        [Column(TypeName = "nvarchar(200)")]
        public  string  AddressProduction { get; set; }
        
        /// <summary>
        ///  Image Detail (hinh anh mo ta san pham )
        /// </summary>
        public  string AvatarDetails { get; set; }
        
        /// <summary>
        ///  save Path 
        /// </summary>
        [NotMapped]
        public  IFormFile photoPath { get; set; }
        
        /// <summary>
        /// Number Product (so luong san pham )
        /// </summary>
        public  int Number { get; set; }
        
        //link the tables
        
        /// <summary>
        /// Id table ColorProduct ForeignKey
        /// </summary>
        public int ColorProductId { get; set; }
        [ForeignKey("ColorProductId")]
        
        public ColorProduct ColorProduct { get; set; }
        
        /// <summary>
        /// Id table SizeProduct ForeignKey
        /// </summary>
        public int MakerProductId { get; set; }
        [ForeignKey("MakerProductId")]
        
        public MakerProduct MakerProduct { get; set; }
        
        /// <summary>
        /// Id table StatusProduct ForeignKey
        /// </summary>
        public int StatusProductId { get; set; }
        [ForeignKey("StatusProductId")] 
        
        public StatusProduct StatusProduct { get; set; }
        
        /// <summary>
        /// Id table Image ForeignKey
        /// </summary>
        public int CategoryProductId  { get; set; }
        [ForeignKey("CategoryProductId")]
        public CategoryProduct CategoryProduct { get; set; }
        
        /// <summary>
        /// id GenderProduct
        /// </summary>
        public  int GenderProductId { get; set; }
        [ForeignKey("GenderProductId")]
        
        public  Gender Gender { get; set; }

    }
}