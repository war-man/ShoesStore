using System;
using System.Collections.Generic;
using System.Linq;
using CoV.Service.DataModel;
using System.Security.Claims;
using System.Threading.Tasks;
using CoV.Common.Infrastructure;
using CoV.Common.Resources;
using Microsoft.AspNetCore.Mvc;
using CoV.Service.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace CoV.Web.Controllers
{
    /// <summary>
    /// Controller Account 
    /// </summary>
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        /// <summary>
        /// Constructor
        /// </summary>
        public AccountController(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        /// <summary>
        /// Login httpget
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Login httppost
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Login(model);
                if (user == null)
                {
                    ModelState.AddModelError(String.Empty, MessageResource.UserLoginFailed);
                    return View(model);
                }

                var claims = new List<Claim>
                {
                    new Claim(Constants.ClaimName.AccountId, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role, user.Role.RoleName),
                    new Claim(ClaimTypes.Email, user.Id.ToString()),
                };
                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                // Storage cookies 
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.UtcNow.AddMinutes(100)
                    });
                return Redirect("/Product/getall");
            }

            return View(model);
        }

        /// <summary>
        /// LogOut 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            //save system log
            //HttpContext.Session.Remove(Constants.SessionKey);
            Response.Cookies.Delete(Constants.ClaimName.UserName);
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        /// <summary>
        /// show User
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Policy = Constants.Role.Admin)]
        public IActionResult Index()
        {
            var users = _userService.Users();
            return
                View(users);
        }

        /// <summary>
        /// View User
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Policy = Constants.Role.Admin)]
        public IActionResult CreateOrUpdate(int id)
        {
            var model = new UserViewModel();
            model.Roles = _roleService.GetAll().Select(x => new RoleViewModel()
            {
                RoleName = x.RoleName,
                Id = x.Id
            }).ToList();
            if (id <= 0)
            {
                model.ExpiredDate = DateTime.Now;
                model.ImageAvatar = Constants.ImageUserDefail.imageAvatar;
                return View(model);
            }
            else
            {
                var user = _userService.GetbyId(id);
                user.Roles = model.Roles;
                return View(user);
            }
        }

        /// <summary>
        /// Create User
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrUpdate(UserViewModel model)
        {
            _userService.CreateOrUpdate(model);
            return Redirect("/Account/index");
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = Constants.Role.Admin)]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Redirect("/Account/index");
        }

        /// <summary>
        /// Show page update user accessde
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ExpiredDate()
        {
            var name = HttpContext.User.Identity.Name;
            var user = _userService.GetByName(name);
            user.ExpiredDate = DateTime.Now;
            return View(user);
        }

        /// <summary>
        /// Update Datetime
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ExpiredDate(UserViewModel model)
        {
            var name = HttpContext.User.Identity.Name;
            var user = _userService.GetByName(name);
            user.ExpiredDate = model.ExpiredDate;
            _userService.CreateOrUpdate(user);
            return Redirect("/Student/show");
        }
    }
}