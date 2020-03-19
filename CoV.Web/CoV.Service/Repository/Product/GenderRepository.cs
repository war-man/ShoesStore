using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// Repository Interface Product
    /// </summary>
    public interface IGenderRepository : IGenericRepository<Gender>
    {
    }
    public class GenderRepository :  GenericRepository<Gender>, IGenderRepository
    {
        /// <summary>
        /// Product repository Gender
        /// </summary>
        /// <param name="dbContext"></param>
        public GenderRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}