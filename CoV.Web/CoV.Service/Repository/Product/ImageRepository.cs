using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// Repository Interface Image Product
    /// </summary>
    public interface IImageRepository : IGenericRepository<Image>
    {
        
    }
    public class ImageRepository :  GenericRepository<Image>, IImageRepository
    {
        /// <summary>
        /// Product Image repository 
        /// </summary>
        /// <param name="dbContext"></param>
        public ImageRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}