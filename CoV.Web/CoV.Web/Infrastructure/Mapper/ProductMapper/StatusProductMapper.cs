using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class StatusProductMapper : Profile
    {
        public StatusProductMapper()
        {
            CreateMap<StatusProduct, StatusProductViewModel>();
            CreateMap<StatusProductViewModel, StatusProduct>();
        }
    }
}