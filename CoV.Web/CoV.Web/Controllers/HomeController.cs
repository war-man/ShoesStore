using System;
using System.Collections.Generic;
using CoV.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CoV.Service.DataModel;

namespace CoV.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly IProductDetailsService _productDetailsService;

        public HomeController(IProductService productService , ICustomerService customerService, IProductDetailsService productDetailsService)
        {
            _productService = productService;
            _customerService = customerService;
            _productDetailsService = productDetailsService;
        }
        
        
        [HttpGet]
        public IActionResult Home()
        {
            ViewBag.getLishFamale = _productService.GetListShoesFemale();
            ViewBag.getLishMale = _productService.GetListShoesMale();
            ViewBag.getLishBaby = _productService.GetListShoesBaby();
            ViewBag.getLishSporst= _productService.GetListShoesSporst();
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
        public IActionResult ProductDetail(int id )
        {
           var product = _productService.GetById(id);
            ViewBag.product = product;
            ViewBag.productDetail = _productDetailsService.GetByIdCart(product.Id);
            var producdetails =_productDetailsService.GetByIdCart(product.Id);
            var pro =_productService.GetAll();
            List<ProductViewModel> list = new List<ProductViewModel>();
            foreach (var item in pro)
            {
                if(list.Count >=9){break;}
                else
                {
                    list.Add(item);

                }
            }

            ViewBag.model = list;
            return View( );
        }
    }
}