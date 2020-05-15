

namespace CoV.Service.DataModel
{
    /// <summary>
    /// Login View  Model
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// User Id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// User Name
        /// </summary>
        public string Username { get; set; }
        
        /// <summary>
        /// pass Word
        /// </summary>
        public string Password { get; set; }
    }
}