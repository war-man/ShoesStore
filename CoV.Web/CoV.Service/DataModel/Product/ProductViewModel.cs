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
        public  string Name { get; set; }
        
        /// <summary>
        /// Code Product (Ma san pham)
        /// </summary>
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
        /// Details Product (Mo ta san pham )
        /// </summary>
        public  string Details { get; set; }
        
        /// <summary>
        ///  Image Detail (hinh anh mo ta san pham )
        /// </summary>
        public  string AvatarDetails { get; set; }
        
        /// <summary>
        /// get Path
        /// </summary>
        public IFormFile PhotoPath { get; set;  }

        
        /// <summary>
        /// Id table Image ForeignKey (the loai san pam)
        /// </summary>
        public int CategoryProductId  { get; set; }
        public CategoryProduct CategoryProduct { get; set; }
        public List<CategoryProductViewModel> CategoryProductViewModels { get; set; }
        
        /// <summary>
        /// id GenderProduct (gio tinh)
        /// </summary>
        public  int GenderProductId { get; set; }
        public  Gender Gender { get; set; }
        public List<GenderViewModel> GenderViewModels { get; set; }

        
        /// <summary>
        /// id GenderProduct (gio tinh)
        /// </summary>
        public  int MakerProductId  { get; set; }
        public  MakerProduct MakerProduct { get; set; }
        public List<MakerProductViewModel> MakerProductViewModels { get; set; }

        
    
       
    }
}