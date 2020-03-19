using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class SizeProductMapper :Profile
    {
        public SizeProductMapper()
        {
            CreateMap<MakerProduct, MakerProductViewModel>();
            CreateMap<MakerProductViewModel, MakerProduct>();
        }
    }
}