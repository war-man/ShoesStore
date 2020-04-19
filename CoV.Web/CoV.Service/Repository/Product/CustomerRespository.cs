using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    public interface ICustomerRespository : IGenericRepository<Customer>
    {
        
    }
    
    public class CustomerRespository : GenericRepository<Customer>,ICustomerRespository
    {
        public CustomerRespository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}