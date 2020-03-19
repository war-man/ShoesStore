using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
   
    /// <summary>
    /// Repository Interface Product  Category
    /// </summary>
    public interface IColorProductRepository : IGenericRepository<ColorProduct>
    {
        
    }
    public class ColorProductRepository : GenericRepository<ColorProduct>,IColorProductRepository
    {
        /// <summary>
        /// Product Category repository
        /// </summary>
        /// <param name="dbContext"></param>
        public ColorProductRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}