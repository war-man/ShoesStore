using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class GenderMapper : Profile
    {
        public GenderMapper()
        {
            CreateMap<Gender, GenderViewModel>();
            CreateMap<GenderViewModel, Gender>();
        }
    }
}