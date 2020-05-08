using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoV.DataAccess.Data
{
    /// <summary>
    /// Table User
    /// </summary>
    public class User
    {
        /// <summary>
        /// Table User
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// User Name
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string UserName { get; set; }
        
        /// <summary>
        /// pass Word
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; }
        
        /// <summary>
        /// FirstDate
        /// </summary>
        public DateTime? FirstDate { get; set; }  
        
        /// <summary>
        /// expired date
        /// </summary>
        public DateTime? ExpiredDate { get; set; }  
        
        /// <summary>
        /// request an extension 
        /// </summary>
        public  int? Request { get; set; }
        

        /// <summary>
        /// Avatar User
        /// </summary>
        [Column(TypeName = "nvarchar(200)")]
        public string ImageAvatar { get; set; }
        
        /// <summary> 
        /// Connection RoleId Table role
        /// </summary>
        public int RoleId { get; set; }  
       
        /// <summary>
        /// foreign key 
        /// </summary>
        [ForeignKey("RoleId")]
        public  Role Role { get; set; }
    }
}