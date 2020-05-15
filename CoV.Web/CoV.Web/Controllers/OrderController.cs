using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using CoV.Service.DataModel;
using CoV.Service.Service;
using CoV.Web.Infrastructure.Helper;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IProductDetailsService  _productDetailsService;

        public OrderController(IOrderService orderService, IProductService productService,IOrderStatusService orderStatusService, IProductDetailsService productDetailsService)
        {
            _orderService = orderService;
            _productService = productService;
            _productDetailsService = productDetailsService;
        }

        /// <summary>
        /// Get All Oder
        /// </summary>
        /// <returns> view model</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var order = _orderService.GetAll().Where(x => x.StatusId ==1);
            foreach (var item in order)
            {
                item.Product = _productService.GetById(item.ProductId);
            }
            return
                View(order);
        }
        
        /// <summary>
        /// Get All Oder
        /// </summary>
        /// <returns> view model</returns>
        [HttpGet]
        public IActionResult OrderBuy()
        {
            var order = _orderService.GetAll().Where(x => x.StatusId ==6);
            foreach (var item in order)
            {
                item.Product = _productService.GetById(item.ProductId);
            }
            return
                View(order);
        }
        
        [HttpGet]
        public IActionResult CreateOrder(    )
        {
            List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            foreach (var item in cart)
            {
                var productdetails = _productDetailsService
                    .GetByProductColor(item.ProductId, item.Size);
                if (productdetails != null && productdetails.NumberProduct >= item.Quantity)
                {
                    productdetails.NumberProduct -= item.Quantity;
                    _productDetailsService.CreateOrUpdate(productdetails);
                }
            }
            _orderService.CreateOrUpdate(cart);
            HttpContext.Session.Remove("cart"); 
            return Redirect("/home/home");
        }
        
        [HttpGet]
        public IActionResult Comback(int id)
        {
            var order = _orderService.getById(id);
            var productdetails = _productDetailsService
                .GetByProductColor(order.ProductId, order.Size);
            if (productdetails != null)
            {
                productdetails.NumberProduct += order.Quantity;
                _productDetailsService.CreateOrUpdate(productdetails);
            }
            _orderService.Delete(id);
            return  Redirect("/Shiper/DangGiao");
        }
        
        [HttpGet]
        public IActionResult UpdateStatus(int id)
        {
            var order = _orderService.UpdateToShiper(id);
            return  new JsonResult(order);
        }
        
        [HttpGet]
        public IActionResult ShiperNhap(int id)
        {
            var order = _orderService.UpdateShipNhan(id);
            return  new JsonResult(order);
        }
        /// <summary>
        /// Delete Product 
        /// </summary>
        /// <param name="id"></param>
        public IActionResult Delete(int id)
        {
            _orderService.Delete(id);
            return RedirectToAction("GetAll");
        }
    }
}