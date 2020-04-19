using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// Repository Interface Product  Category
    /// </summary>
    public interface ICartRespository : IGenericRepository<Cart>
    {
    }

    public class CartRespository : GenericRepository<Cart>, ICartRespository
    {
        /// <summary>
        /// Product Category repository
        /// </summary>
        /// <param name="dbContext"></param>
        public CartRespository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}