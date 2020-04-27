using System.Collections.Generic;
using AutoMapper;
using Castle.Core.Internal;
using CoV.Service.DataModel;
using CoV.Service.Service;
using CoV.Web.Infrastructure.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public CartController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var sessionEmail = HttpContext.Session.GetString("SessionEmail");
            var cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");

            if (cart != null)
            {
                var cartCustomer = cart.FindAll(x => x.Name == sessionEmail);
                ViewBag.cart = cartCustomer;
                ViewBag.total = cart.Count;
                return View(ViewBag.cart);
            }
            return Redirect("/Cart/Index2");
        }
        
        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }
        
        
        [HttpGet]
        public IActionResult Buy(int id)
        {
            var sessionEmail = HttpContext.Session.GetString("SessionEmail");
            if (sessionEmail == null)
            {
                return Redirect("/Customer/CreateAndUpdate");
            }
            else
            {
                var product = _productService.GetByIdCart(id);
                if (SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart") == null)
                {
                    List<CartViewModel> cart = new List<CartViewModel>();
                
                    cart.Add(new CartViewModel {Product =  product,Name = sessionEmail ,Size = 34,ProductId = id, Quantity = 1, TotalPrice = product.Price });
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                }
                else
                {
                    List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
                    int index = IsExist(id);
                    if (index != -1)
                    {
                        cart[index].Quantity++;
                        cart[index].TotalPrice= cart[index].Product.Price* cart[index].Quantity;
                    }
                    else
                    {
                        cart.Add(new CartViewModel {Product =  product,Name = sessionEmail ,Size = 34,ProductId = id, Quantity = 1, TotalPrice = product.Price });


                    }
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                }
                return Redirect("/home/home");
            }
        }
        
        
       [HttpGet]
        public IActionResult Remove(int id)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            int index = IsExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int IsExist(int id)
        {
            var sessionEmail = HttpContext.Session.GetString("SessionEmail");
            List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id) && cart[i].Name.Equals(sessionEmail) )
                {
                    return i;
                }
            }
            return -1;
        }

        [HttpGet]
        public IActionResult EditQuantity( int id, int quantity)
        {
            List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            var product = _productService.GetByIdCart(id);
            if (quantity <= 0)
            {
                return new JsonResult(cart);
            }
            int index = IsExist(id);
            if (index != -1)
            {
                cart[index].Quantity = quantity + 1;
                cart[index].TotalPrice = cart[index].Quantity * cart[index].Product.Price;
            }
            else
            {
                cart.Add(new CartViewModel {Product =  product, ProductId = id, Quantity = 1 });

            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return new JsonResult(cart);
        }
        
        [HttpGet]
        public IActionResult EditQuantityDown( int id, int quantity)
        {
            List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            var product = _productService.GetByIdCart(id);
            int index = IsExist(id);
            if (quantity <= 0)
            {
                return new JsonResult(cart);
            }
            if (index != -1)
            {
                cart[index].Quantity = quantity - 1;
            }
            else
            {
                cart.Add(new CartViewModel {Product =  product, ProductId = id, Quantity = 1 });
                cart[index].TotalPrice = cart[index].Quantity * cart[index].Product.Price;

            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return new JsonResult(cart);
        }
        
        [HttpGet]
        public IActionResult EditQuantityMouseleave( int id, int quantity)
        {
            List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            var product = _productService.GetByIdCart(id);
            int index = IsExist(id);
            if (quantity <= 0)
            {
                return new JsonResult(cart);
            }
            if (index != -1)
            {
                cart[index].Quantity = quantity;
                cart[index].TotalPrice = cart[index].Quantity * cart[index].Product.Price;
            }
            else
            {
                cart.Add(new CartViewModel {Product =  product, ProductId = id, Quantity = 1 });

            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return new JsonResult(cart);
        }
        
        [HttpGet]
        public IActionResult EditSizeMouseleave( int id, int size)
        {
            List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            var product = _productService.GetByIdCart(id);
            int index = IsExist(id);
            if (size <= 34 || size >=46)
            {
                return new JsonResult(cart);
            }
            if (index != -1)
            {
                cart[index].Size = size;
            }
            else
            {
                cart.Add(new CartViewModel {Product =  product, ProductId = id, Quantity = 1 });

            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return new JsonResult(cart);
        }
    }
    
}