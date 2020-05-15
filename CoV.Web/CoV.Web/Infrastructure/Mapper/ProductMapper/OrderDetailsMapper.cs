using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class OrderDetailsMapper :Profile
    {
        public OrderDetailsMapper()
        {
            CreateMap<OrderDetals, OrderDetailsViewModel>();
            CreateMap<OrderDetailsViewModel, OrderDetals>();
        }
    }
}