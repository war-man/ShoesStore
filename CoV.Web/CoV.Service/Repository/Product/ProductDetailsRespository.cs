using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    public interface IProductDetailsRespository : IGenericRepository<ProductDetails>
    {
        
    }
    
    public class ProductDetailsRespository : GenericRepository<ProductDetails>, IProductDetailsRespository
    {
        /// <summary>
        /// Product repository
        /// </summary>
        /// <param name="dbContext"></param>
        public ProductDetailsRespository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}