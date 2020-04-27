using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    /// <summary>
    /// Repository Interface Order
    /// </summary>
    public interface IOrderStatusRespository : IGenericRepository<StatusOrder>
    {
    }

    public class OrderStatusRespository : GenericRepository<StatusOrder>, IOrderStatusRespository
    {
        /// <summary>
        /// order repository
        /// </summary>
        /// <param name="dbContext"></param>
        public OrderStatusRespository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}