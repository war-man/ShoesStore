using AutoMapper;
using CoV.Service.DataModel;
using GreenWhale.Alipay.Domain;

namespace CoV.Web.Infrastructure.Mapper
{
    public class CategoryMapper :Profile
    {
        public CategoryMapper()
        {
            CreateMap<Category, CategoryProductViewModel>();
            CreateMap<CategoryProductViewModel,Category >();
        }
    }
}