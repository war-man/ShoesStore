namespace CoV.Service.DataModel
{
    /// <summary>
    /// Change Pass Word 
    /// </summary>
    public class ChangePassWordModel
    {
        /// <summary>
        /// Table User
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