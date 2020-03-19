using System.Collections.Generic;

namespace CoV.DataAccess.Data
{
    /// <summary>
    /// Table Classes
    /// </summary>
    public class Classes
    {
        /// <summary>
        /// claser Id
        /// </summary>
        public  int Id { get; set; }
        
        /// <summary>
        /// Property class classname
        /// </summary>
        public  string ClassName { get; set; }
        
        /// <summary>
        /// Property class classmember
        /// </summary>
        public  int ClassMember { get; set; } 
        
        /// <summary>
        /// List  student
        /// </summary>
        public ICollection<Student> Students { get; set; }
    }
}