using System.ComponentModel.DataAnnotations.Schema;

namespace CoV.DataAccess.Data
{
    /// <summary>
    /// Table Student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student ID
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Property student code
        /// </summary>
        public int StudentMasv { get; set; }
        
        /// <summary>
        /// Student Name
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string StudentName { get; set; }
        
        /// <summary>
        /// avatar of Student 
        /// </summary>
        public string StudentAvatar { get; set; }
        
        /// <summary>
        /// Student Age
        /// </summary>
        public int StudentAge { get; set; }
        
        /// <summary>
        /// Student Address
        /// </summary>
        public string StudentAddress { get; set; }
        
        /// <summary>
        /// foreignkey class id
        /// </summary>
        public int ClasserId { get; set; }
        [ForeignKey("ClasserId")]
        
        // Lish Classes 
        public Classes Classes { get; set; }
    }
}