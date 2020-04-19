using CoV.Service.DataModel;
using CoV.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        /// <summary>
        /// Get All Product 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var Products = _productService.GetAll();
            return
            View(Products);
        }
        
        /// <summary>
        ///  action get request Create Or Update 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateOrUpdate( int Id)
        {
            var model = _productService.GetById(Id);
             return View(model);
        }
        /// <summary>
        /// action get reponse Create Or Update 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateOrUpdate(ProductViewModel model)
        {
             _productService.CreateOrUpdate(model);
            return RedirectToAction("GetAll");
        }
        
        /// <summary>
        /// Delete Product 
        /// </summary>
        /// <param name="Id"></param>
        public IActionResult Delete(int Id)
        {
            _productService.Delete(Id);
            return RedirectToAction("GetAll");
        }
    }
}