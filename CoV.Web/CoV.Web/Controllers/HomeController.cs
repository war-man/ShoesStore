using CoV.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        
        
        [HttpGet]
        public IActionResult Home()
        {
            ViewBag.getLishFamale = _productService.GetListShoesFemale();
            ViewBag.getLishMale = _productService.GetListShoesMale();
            return View();
        }
        
        public IActionResult Singin()
        {
            return View();
        }
        
        public IActionResult SingUp()
        {
            return View();
        }
        
        public IActionResult TemplateInvoid()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult Blog()
        {
            return View();
        }
        
        public IActionResult BlogDetail()
        {
            return View();
        }
        
        public IActionResult Cart()
        {
            return View();
        }
        
        public IActionResult Checkout01()
        {
            return View();
        }
        
        public IActionResult Checkout02()
        {
            return View();
        }
        
        public IActionResult Contact()
        {
            return View();
        }
        
        public IActionResult Product()
        {
            return View();
        }
        
        /// <summary>
        ///  show product details 
        /// </summary>
        /// <returns>view</returns>
        [HttpGet]
        public IActionResult ProductDetail( int id)
        {
            var model = _productService.GetById(id);
            return View(model);
        }
    }
    
  
        
}