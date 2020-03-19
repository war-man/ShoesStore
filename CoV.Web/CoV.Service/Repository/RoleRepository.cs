using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// role for Repository
    /// </summary>
    public interface IRoleRepository : IGenericRepository<Role>
    {  
    }
    
    /// <summary>
    /// Repository classes
    /// </summary>
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        /// <summary>
        /// role repository
        /// </summary>
        /// <param name="dbContext"></param>
        public RoleRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}