using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    public interface IOrderDetailsRespository : IGenericRepository<OrderDetals>
    {
        
    }
    public class OrderDetailsRespository : GenericRepository<OrderDetals> ,IOrderDetailsRespository
    {
        /// <summary>
        /// order repository
        /// </summary>
        /// <param name="dbContext"></param>
        public OrderDetailsRespository (AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}