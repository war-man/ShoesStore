using CoV.Service.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;


namespace CoV.Web.Controllers
{
    [Route("api/[controller]")]
    public class UserApiController : Controller
    {
        private readonly IUserService  _userService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userService"></param>
        public UserApiController(IUserService userService)
        {
            _userService = userService;
        }
        
        /// <summary>
        /// API acction get all user
        /// </summary>
        /// <returns></returns>
        [HttpGet] 
        [Authorize(AuthenticationSchemes = 
            JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult GetAll()
        {
            var getAll = _userService.GetAll();
            return Ok(getAll);
        }
    }
}