using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// Repository Interface Product
    /// </summary>
    public interface IProductRespository : IGenericRepository<Product>
    {
        
    }
    public class ProductRespository :  GenericRepository<Product>, IProductRespository
    {
        /// <summary>
        /// Product repository
        /// </summary>
        /// <param name="dbContext"></param>
        public ProductRespository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}