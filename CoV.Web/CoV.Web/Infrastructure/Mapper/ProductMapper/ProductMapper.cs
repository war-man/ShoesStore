using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductViewModel, Product>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}