using System;
using System.Linq;
using CoV.Common.Resources;
using CoV.Service.DataModel;
using CoV.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class ProductDetailsController : Controller
    {
        private readonly IProductDetailsService _productDetailsService;
        private readonly IProductService _productService;
        private readonly IColorProductService _colorProductService;
        private readonly IStatusProductService _statusProductService;

        public ProductDetailsController(IProductDetailsService productDetailsService, IColorProductService colorProductService, IStatusProductService statusProductService, IProductService productService)
        {
            _productDetailsService = productDetailsService;
            _colorProductService = colorProductService;
            _statusProductService = statusProductService;
            _productService = productService;
        }
        // GET
        public IActionResult GetAll()
        {
            var product = _productDetailsService.GetAll();
            return
            View(product);
        }
        
        [HttpGet]        
        public IActionResult Add( int id)
        {
            var model = _productService.GetById(id);
            ViewBag.name = model.Name;
            ViewBag.id = model.Id;
            ViewBag.sku = model.Sku;
            var color = _colorProductService.GetAll();
            ViewBag.color = color;              
            var status = _statusProductService.GetAll();
            ViewBag.status = status;    
            ViewBag.model = model;
            return View();
        }
        
        /// <summary>
        /// action get reponse Create 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add(ProductDetailsViewModel model)
        {
            var productdetails = _productDetailsService
                .GetByProductColor(model.ProductId, model.SizeProduct);
            if (productdetails != null)
            {
                ModelState.AddModelError(String.Empty, MessageResource.ProductdetailNull);
                var viewModel = _productService.GetById(productdetails.ProductId);
                ViewBag.name = viewModel.Name;
                ViewBag.id = viewModel.Id;
                ViewBag.sku = viewModel.Sku;
                var color = _colorProductService.GetAll();
                ViewBag.color = color;              
                var status = _statusProductService.GetAll();
                ViewBag.status = status;    
                ViewBag.model = model;
                return View(model);
            }
            else
            {
                model.Id = 0;
                model.Product = _productService.GetById(model.ProductId);
                _productDetailsService.Add(model);
            }
            return RedirectToAction("GetAll");
        }
        
        
        /// <summary>
        ///  action get request Create Or Update 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateOrUpdate( int id)
        {
            var model = _productDetailsService.GetById(id);
            var product = _productService.GetById(model.ProductId);
            ViewBag.name = product.Name;
            ViewBag.sku = product.Sku;
            var status = _statusProductService.GetAll();
            ViewBag.status = status;    
            ViewBag.size = model.SizeProduct;    
            ViewBag.model = model;
            return View(model);
        }
        /// <summary>
        /// action get reponse Create Or Update 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateOrUpdate(ProductDetailsViewModel model)
        {
                _productDetailsService.CreateOrUpdate(model);
            return RedirectToAction("GetAll");
        }
        
        /// <summary>
        /// Delete Product Details
        /// </summary>
        /// <param name="id"></param>
        public IActionResult Delete(int id)
        {
            _productDetailsService.Delete(id);
            return RedirectToAction("GetAll");
        }
        
        
    }
}