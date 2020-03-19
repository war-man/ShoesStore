using System.DrawingCore;
using AutoMapper;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class imageMapper : Profile
    {
        public imageMapper()
        {
            CreateMap<Image, ImageProductViewModel>();
            CreateMap<ImageProductViewModel, Image>();
        }
    }
}