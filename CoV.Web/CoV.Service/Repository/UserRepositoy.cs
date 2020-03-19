using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// Interface  for UserRepository
    /// </summary>
    public interface IUserRepositoy :IGenericRepository<User>
    {
        
    }
    
    /// <summary>
    /// Repository Student
    /// </summary>
    public class UserRepositoy : GenericRepository<User>, IUserRepositoy
    {
        /// <inheritdoc />
        /// <summary>
        /// UserRepository
        /// </summary>
        /// <param name="dbContext"></param>  
        public UserRepositoy(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}