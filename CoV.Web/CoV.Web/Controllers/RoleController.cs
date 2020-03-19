using CoV.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        
        public IActionResult GetAll()
        {
            var role = _roleService.GetAll();
            return 
            View(role);
        }
    }
}