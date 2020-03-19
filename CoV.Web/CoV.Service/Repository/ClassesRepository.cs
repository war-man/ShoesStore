using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// Class for Repository
    /// </summary>
    public interface IClassesRepository : IGenericRepository<Classes>
    {  
    }
    
    /// <summary>
    /// Repository classes
    /// </summary>
    public class ClassesRepository : GenericRepository<Classes>, IClassesRepository
    {
        /// <summary>
        /// class repository
        /// </summary>
        /// <param name="dbContext"></param>
        public ClassesRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}