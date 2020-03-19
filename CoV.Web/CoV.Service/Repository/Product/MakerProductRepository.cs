using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// Interface Repository SizeProduct
    /// </summary>
    public interface IMakerProductRepository : IGenericRepository<MakerProduct>
    {
        
    }
    public class MakerProductRepository : GenericRepository<MakerProduct> ,IMakerProductRepository
    {
        /// <summary>
        /// Product size product Repository
        /// </summary>
        /// <param name="dbContext"></param>
        public MakerProductRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}