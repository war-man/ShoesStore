using System.Collections.Generic;
using CoV.DataAccess.Data;
using Microsoft.AspNetCore.Http;

namespace CoV.Service.DataModel
{
    /// <summary>
    /// Student Model
    /// </summary>
    public class StudentViewModel
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
        public string StudentName { get; set; }
         
        /// <summary>
        /// Student Age
        /// </summary>
        public int StudentAge { get; set; }
        
        /// <summary>
        /// Student Address
        /// </summary>
        public string StudentAddress { get; set; }
        
        /// <summary>
        /// avatar of Student 
        /// </summary>
        public IFormFile PhotoPath { get; set; }
        
        /// <summary>
        /// avatar of Student 
        /// </summary>
        public string StudentAvatar { get; set; }
        
        /// <summary>
        /// Id of table clases
        /// </summary>
        public int ClasserId { get; set; }
        
        /// <summary>
        /// class model, Get atribute Classes
        /// </summary>
        public  List<CreateClasserModel> ClasserModels { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public Classes Classes { get; set; }
    }
}