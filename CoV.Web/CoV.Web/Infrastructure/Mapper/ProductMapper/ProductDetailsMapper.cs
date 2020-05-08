using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class ProductDetailsMapper : Profile
    {
        public ProductDetailsMapper()
        {
            CreateMap<ProductDetailsViewModel, ProductDetails>();
            CreateMap<ProductDetails, ProductDetailsViewModel>();
        }
    }
}