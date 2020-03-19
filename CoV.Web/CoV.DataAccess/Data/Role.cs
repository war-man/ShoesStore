using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoV.DataAccess.Data
{
    /// <summary>
    /// Table Role  (Admin User Customer)
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Property Id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Property RoleName
        /// </summary>
        public string RoleName { get; set; }
        
        /// <summary>
        /// List  User
        /// </summary>
        public ICollection<User>  Users{get; set; }
    }
}