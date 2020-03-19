using CoV.DataAccess.Data;
using CoV.Service.DataModel;
using GreenWhale.CoapCore.Communication.Coap;
using Profile = AutoMapper.Profile;

namespace CoV.Web.Infrastructure.Mapper
{
    /// <summary>
    /// this class create Mapper Student with classes viewmodel
    /// </summary>
    public class RoleMapper : Profile
    {
        /// <summary>
        /// Contructor Student profile  Map classes to Classes viewmodel 
        /// </summary>
        public RoleMapper()
        {
            CreateMap<RoleViewModel, Role>();
            CreateMap<Role, RoleViewModel>();
        }
    }
}