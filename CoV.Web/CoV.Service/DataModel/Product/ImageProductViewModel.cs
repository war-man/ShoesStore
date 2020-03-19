using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoV.Service.DataModel
{
    public class ImageProductViewModel
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