using System;
using CoV.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;

        public HomeController(IProductService productService , ICustomerService customerService)
        {
            _productService = productService;
            _customerService = customerService;
        }
        
        
        [HttpGet]
        public IActionResult Home()
        {
            ViewBag.getLishFamale = _productService.GetListShoesFemale();
            ViewBag.getLishMale = _productService.GetListShoesMale();
            ViewBag.Name = HttpContext.Session.GetString("SessionName");  
            ViewBag.Email = HttpContext.Session.GetString("SessionEmail");  
            return View();
        }
        
        public IActionResult Singin()
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
        
        /// <summary>
        /// Checkout Customer 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Checkout01()
        {
            var id = Int32.Parse(HttpContext.Session.GetString("SessionId"));
            var customer = _customerService.GetById(id);
            return View(customer);
        }
        
        public IActionResult Checkout02()
        {
            return View();
        }
        
        [HttpGet]
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
        public IActionResult ProductDetail( )
        {
//            var model = _productService.GetById(id);
            return View();
        }
    }
    
  
        
}