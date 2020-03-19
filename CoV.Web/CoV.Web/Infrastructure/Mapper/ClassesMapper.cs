using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    /// <summary>
    /// Thhis Class Create mapper Classes with Classes viewmodl
    /// </summary>
    public class ClassesMapper : Profile
    {
        /// <summary>
        /// Contructor ClassesProfile  Map User to User ViewMdel 
        /// </summary>
            public ClassesMapper()
            {
                CreateMap<CreateClasserModel, Classes>();
                CreateMap<Classes, CreateClasserModel>();
            }
       
    }
}