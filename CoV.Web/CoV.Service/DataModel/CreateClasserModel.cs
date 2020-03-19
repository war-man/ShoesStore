namespace CoV.Service.DataModel
{
    /// <summary>
    /// Class View  Model
    /// </summary>
    public class CreateClasserModel
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
    }
}