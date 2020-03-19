using System;
using System.Collections.Generic;
using CoV.DataAccess.Data;
using Microsoft.AspNetCore.Http;

namespace CoV.Service.DataModel
{
    /// <summary>
    /// User View Model 
    /// </summary>
    public class UserViewModel
    {
        /// <summary>
        /// Table User
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// User Name
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// pass Word
        /// </summary>
        public string Password { get; set; }
        
        /// <summary>
        /// Firstdate of User
        /// </summary>
        public DateTime FirstDate { get; set; }  
        
        /// <summary>
        /// expired date
        /// </summary>
        public DateTime ExpiredDate { get; set; }  
        
        /// <summary>
        /// Avatar User
        /// </summary>
        public string ImageAvatar { get; set; }
        
        /// <summary>
        /// iformfile imager Avatar
        /// </summary>
        public IFormFile PhotoPath { get; set; }
        
        /// <summary>
        /// request an extension 
        /// </summary>
        public  int Request { get; set; }
        
        /// <summary>
        /// Connection RoleId
        /// </summary>
        public int RoleId { get; set; }  
        
        public Role Role { get; set; }
        /// <summary>
        /// get Role attribute
        /// </summary>
        public  List<RoleViewModel> Roles { get; set; }
    }
}