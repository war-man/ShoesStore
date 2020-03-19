using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// Repository Interface Product  Category
    /// </summary>
    public interface ICategoryProductRepository : IGenericRepository<CategoryProduct>
    {
        
    }
    public class CategoryProductRepository : GenericRepository<CategoryProduct>,ICategoryProductRepository
    {
        /// <summary>
        /// Product Category repository
        /// </summary>
        /// <param name="dbContext"></param>
        public CategoryProductRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}