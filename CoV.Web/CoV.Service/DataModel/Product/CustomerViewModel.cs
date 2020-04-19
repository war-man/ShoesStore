using System;

namespace CoV.Service.DataModel
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        
        public string FirstName  { get; set; }
        
        public string LastName { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public  string Email { get; set; }
        
        public  DateTime? CreateDate { get; set; }
        
        public DateTime? CreateUpdate { get; set; }
        
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string PassWord { get; set; }
        
        public string ConfiguePassWord { get; set; }
    }
}