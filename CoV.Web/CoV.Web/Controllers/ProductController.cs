using System.Collections.Generic;
using System.Linq;
using CoV.Common.Infrastructure;
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
            var products = _productService.GetAll();
            return
            View(products);
        }
        
        /// <summary>
        ///  action get request Create Or Update 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateOrUpdate( int id)
        {
            var model = _productService.GetById(id);
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
        /// <param name="id"></param>
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("GetAll");
        }
    
        /// <summary>
        /// get add product Male
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllMale()
        {
            var product = _productService.GetAll().Where(x => x.Gender.GenderName.Equals(Constants.GenderProduct.Male)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if(productmodel.Count >=8){break;}
                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }
        
        /// <summary>
        /// get add product Famale
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllFemale()
        {
            var product = _productService.GetAll().Where(x => x.Gender.GenderName.Equals(Constants.GenderProduct.Female)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if(productmodel.Count >=8){break;}
                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }
        
        /// <summary>
        /// get add product Baby
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllBaby()
        {
            var product = _productService.GetAll().Where(x => x.Gender.GenderName.Equals(Constants.GenderProduct.Baby)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if(productmodel.Count >=8){break;}
                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }
        
        
        /// <summary>
        /// get add product sporst
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoeSporst()
        {
            var product = _productService.GetAll().Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.Giaythethao)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if(productmodel.Count >=8){break;}
                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }
        
        
        /// <summary>
        /// get add product Cs
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoesCs()
        {
            var product = _productService.GetAll().Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.ShoesCs)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if(productmodel.Count >=8){break;}
                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }
        
        /// <summary>
        /// get add product long
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoeLong()
        {
            var product = _productService.GetAll().Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.ShoesLong)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if(productmodel.Count >=8){break;}
                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }
        
        /// <summary>
        /// get add product cs
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoesDa()
        {
            var product = _productService.GetAll().Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.GiayDa)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if(productmodel.Count >=8){break;}
                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }
        
        
        /// <summary>
        /// get add product baby dang yeu
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoesBabyLovely()
        {
            var product = _productService.GetAll().Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.GiayDangYeu)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if(productmodel.Count >=8){break;}
                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }
        
        
        /// <summary>
        /// get add product baby phong cách
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoesBabyStyle()
        {
            var product = _productService.GetAll().Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.GiayDangYeu)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if(productmodel.Count >=8){break;}
                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }
        
        /// <summary>
        /// get add product baby phong cách
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Search( string input)
        {
            var product = _productService.GetAll().Where(c=>c.Name.Contains(input)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if(productmodel.Count >=8){break;}
                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }
    }
}