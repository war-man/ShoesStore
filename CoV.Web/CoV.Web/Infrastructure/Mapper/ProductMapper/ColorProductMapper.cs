using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class ColorProductMapper : Profile
    {
        public ColorProductMapper()
        {
            CreateMap<ColorProduct, ColorProductViewModel>();
            CreateMap<ColorProductViewModel, ColorProduct>();
        }
    }
}