using CoV.DataAccess.Data;
namespace CoV.Service.Repository
{
    /// <summary>
    /// interface for StudentRepository
    /// </summary>
    public interface IStudentRepository : IGenericRepository<Student>
    {
        
    }
    
    /// <summary>
    /// Repository Student
    /// </summary>
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        /// <summary>
        /// StudenRepository
        /// </summary>
        /// <param name="dbContext"></param>
        public StudentRepository(AppDbContext dbContext) : base(dbContext)
        {           
        }
    }
}