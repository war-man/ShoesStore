using  AutoMapper;
using CoV.DataAccess.Data;
using  CoV.Service.DataModel;
namespace CoV.Web.Infrastructure.Mapper
{
    /// <summary>
    /// create mapping
    /// </summary>
    public class UserMapper :Profile
    {
        /// <summary>
        /// Contructor UserProfile Map User to User ViewModel
        /// </summary>
         public UserMapper()
          {
              CreateMap<LoginModel, User>();
              CreateMap<User, LoginModel>();
              CreateMap<ChangePassWordModel, User>();
              CreateMap<UserViewModel, User>();
              CreateMap<User, UserViewModel>();
        
          }    
        }
    }
