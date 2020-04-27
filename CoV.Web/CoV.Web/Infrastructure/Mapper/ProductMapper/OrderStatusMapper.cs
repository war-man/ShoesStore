using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class OrderStatusMapper : Profile
    {
        public OrderStatusMapper()
        {
            CreateMap<StatusOrder, OrderStatusViewModel>();
            CreateMap<OrderStatusViewModel, StatusOrder>();
        }
    }
}