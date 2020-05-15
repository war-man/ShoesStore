using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CoV.Common.Infrastructure;
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
        private readonly IProductDetailsService _productDetailsService;
        private readonly IColorProductService _colorProductService;
        private readonly ICustomerService _customerService;

        public CartController(IProductService productService, IMapper mapper, IProductDetailsService productDetailsService, IColorProductService colorProductService, ICustomerService customerService)
        {
            _productService = productService;
            _productDetailsService = productDetailsService;
            _colorProductService = colorProductService;
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var sessionPhone = HttpContext.Session.GetString("SessionPhone");
            var customer = _customerService.GetAll().FirstOrDefault(x => x.PhoneNumber.Equals(sessionPhone));
            var cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
    
            if (cart != null)
            {
                var cartCustomer = cart.FindAll(x => x.Name == sessionPhone);
                ViewBag.cart = cartCustomer;
                ViewBag.total = cart.Count;
                ViewBag.color =  _colorProductService.GetAll();
                return View(cart);
            }
            return Redirect("/Cart/Index2");
        }
        
        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }
        
        
        [HttpGet]
        public IActionResult Buy(int id, int size, int quantity)
        {
            var sessionEmail = HttpContext.Session.GetString("SessionPhone");
            if (sessionEmail == null)
            {
                return Redirect("/Customer/CreateAndUpdate");
            }
            else
            {
                var productDetails = _productDetailsService.CheckProductDetails(id,size);
                if (productDetails != null)
                {
                    var product = _productService.GetByIdCart(id);
                    if (SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart") == null)
                    {
                        List<CartViewModel> cart = new List<CartViewModel>();
                        if (productDetails.NumberProduct >= quantity)
                        {
                            cart.Add(new CartViewModel {Id= productDetails.Id,Product = product,Name = sessionEmail ,Size = size, ProductId = id, Quantity = quantity, TotalPrice = product.PriceNew*quantity });
                            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                        }
                        else
                        {
                            return new JsonResult("NotException");
                        }
                    }
                    else
                    {
                        List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
                        int index = IsExist(productDetails.Id);
                        if (index != -1)
                        {
                            if (cart[index].Size == size)
                            {
                                if ((quantity +  cart[index].Quantity) < productDetails.NumberProduct)
                                {
                                    cart[index].Quantity = cart[index].Quantity + quantity;
                                    cart[index].TotalPrice= cart[index].Product.PriceNew * cart[index].Quantity;
                                }
                                else
                                {
                                    return new JsonResult("NotException");
                                }
                            }
                        }
                        else
                        {
                            if (productDetails.NumberProduct >= quantity)
                            {
                                cart.Add(new CartViewModel {Id= productDetails.Id,Product = product,Name = sessionEmail ,Size = size, ProductId = id, Quantity = quantity, TotalPrice = product.PriceNew*quantity });
                                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                            }
                            else
                            {
                                return new JsonResult("NotException");
                            }
                        }
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                    }
                }
                else
                {
                    return  new JsonResult("NotPound");
                }
                return Redirect("/Cart/Index");
            }
        }
        
       [HttpGet]
        public IActionResult Remove(int id )
        {
            var sessionEmail = HttpContext.Session.GetString("SessionPhone");
            var cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            int index = IsExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int IsExist(int id)
        {
            var sessionEmail = HttpContext.Session.GetString("SessionPhone");
            List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Id.Equals(id) && cart[i].Name.Equals(sessionEmail) )
                {
                    return i;
                }
            }
            return -1;
        }
      
        /// <summary>
        ///  sucsses
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditQuantityMouseleave( int id, int quantity)
        {
            List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            var productDetails = _productDetailsService.GetById(id);
            int index = IsExist(id);
            if (quantity <= 0)
            {
                return new JsonResult(cart);
            }
            if (index != -1)
            {
                cart[index].Quantity = quantity;
                cart[index].TotalPrice = cart[index].Quantity * cart[index].Product.PriceNew;
            }
            var total = 0;
            foreach (var item in cart)
            {
                total = total + item.TotalPrice;
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            var carts =   new { totalprict =total,quantitys = productDetails.NumberProduct };
            return new JsonResult(carts);
        }
        
        /// <summary>
        /// Size
        /// </summary>
        /// <param name="id"></param>
        /// <param name="size"></param>
        /// <returns></returns>
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

        public IActionResult CkeckNumber(int id, int size)
        {
            var product = _productDetailsService.GetAll()
                .FirstOrDefault(x => x.ProductId.Equals(id) && x.SizeProduct.Equals(size));
            if (product != null )
            {
                var number = product.NumberProduct;
                return new JsonResult(number.ToString());
            }
            return new JsonResult("0");
        }
    }
    
}