using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// Repository Interface Status Product 
    /// </summary>
    public interface IStatusProductRepository : IGenericRepository<StatusProduct>
    {
        
    }
    public class StatusProductRepository :  GenericRepository<StatusProduct>, IStatusProductRepository
    {
        /// <summary>
        /// Product repository StatusProduct
        /// </summary>
        /// <param name="dbContext"></param>
        public StatusProductRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}