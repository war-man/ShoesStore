namespace CoV.Service.DataModel
{
    /// <summary>
    /// login forget password
    /// </summary>
    public class LoginForgetPassword
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
        
        /// <summary>
        /// pass Word
        /// </summary>
        public string PasswordNew { get; set; }
        
        /// <summary>
        /// pass Word
        /// </summary>
        public string PasswordNewConfigure { get; set; }
      
    }
}