using System.Reflection.Metadata;
using System.Security.Claims;
using System.Security.Principal;
using CoV.Common.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{

    /// <summary>
    /// Admin Controler 
    /// </summary>
    [Authorize]
    public class AdminController : Controller
    {
        /// <summary>
        /// show 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return
            View("Index");
        }
    }
}