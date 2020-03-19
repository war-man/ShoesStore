using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace CoV.DataAccess.Data
{
    public class Image
    {
        /// <summary>
        /// Id image
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// path address Image 
        /// </summary>
        [NotMapped]
        public List<string>  ImageName { get; set; }
        

    }
}