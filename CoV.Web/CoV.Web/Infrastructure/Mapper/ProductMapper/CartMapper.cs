using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class CartMapper :Profile
    {
        public CartMapper()
        {
            CreateMap<Cart, CartViewModel>();
            CreateMap<CartViewModel, Cart>();
        }
    }
}