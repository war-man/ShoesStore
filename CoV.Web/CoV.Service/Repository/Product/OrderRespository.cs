using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    
    /// <summary>
    /// Repository Interface Order
    /// </summary>
    public interface IOrderRespository : IGenericRepository<Order>
    {
        
    }
    public class OrderRespository : GenericRepository<Order> ,IOrderRespository
    {
        /// <summary>
        /// order repository
        /// </summary>
        /// <param name="dbContext"></param>
        public OrderRespository (AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}