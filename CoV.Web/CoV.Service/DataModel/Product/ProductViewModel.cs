using System;
using System.Collections.Generic;
using CoV.DataAccess.Data;
using Microsoft.AspNetCore.Http;

namespace CoV.Service.DataModel
{
    public class ProductViewModel
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
        /// get Path
        /// </summary>
        public IFormFile photoPath { get; set;  }
        
        /// <summary>
        /// Number Product (so luong san pham )
        /// </summary>
        public  int Number { get; set; }
        
        //link the tables
        
        /// <summary>
        /// Id table ColorProduct ForeignKey
        /// </summary>
        public int ColorProductId { get; set; }
        public ColorProduct ColorProduct { get; set; }
        
        /// <summary>
        /// Get Attribute ColorProductViewModel
        /// </summary>
        public  List<ColorProductViewModel> ColorProductViewModels { get; set; }
        
        /// <summary>
        /// Id table SizeProduct ForeignKey
        /// </summary>
        public int MakerProductId { get; set; }
        public MakerProduct MakerProduct { get; set; }
        
        /// <summary>
        /// Get Attribute SizeProducts 
        /// </summary>
        public  List<MakerProductViewModel> MakerProductViewModels { get; set; }
        
        /// <summary>
        /// Id table StatusProduct ForeignKey
        /// </summary>
        public int StatusProductId { get; set; }
        public StatusProduct StatusProduct { get; set; }
        
        /// <summary>
        /// Get Attribute Status Product view Model 
        /// </summary>
        public List<StatusProductViewModel> StatusProductViewModels { get; set; }
        
        /// <summary>
        /// Id table Image ForeignKey
        /// </summary>
        public int ImageId  { get; set; }
        public Image Image { get; set; }
        
        /// <summary>
        /// Id table Image ForeignKey
        /// </summary>
        public int CategoryProductId  { get; set; }
        public CategoryProduct CategoryProduct { get; set; }
        
        /// <summary>
        ///  Get list CategoryProductViewModel
        /// </summary>
        public List<CategoryProductViewModel>CategoryProductViewModels { get; set; }
        
        /// <summary>
        /// id GenderProduct
        /// </summary>
        public  int GenderProductId { get; set; }
        public  Gender Gender { get; set; }
        
        /// <summary>
        /// Get list GenderViewModel 
        /// </summary>
        public List<GenderViewModel > GenderViewModels { get; set; }
    }
}