using System.Collections.Generic;
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
        private readonly IOrderStatusService  _orderStatusService;

        public OrderController(IOrderService orderService, IProductService productService,IOrderStatusService orderStatusService)
        {
            _orderService = orderService;
            _productService = productService;
            _orderStatusService = orderStatusService;
        }

        /// <summary>
        /// Get All Oder
        /// </summary>
        /// <returns> view model</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var order = _orderService.GetAll();
            foreach (var item in order)
            {
                item.Product = _productService.GetById(item.ProductId);
            }
            return
                View(order);
        }
        
        [HttpGet]
        public IActionResult CreateOrder()
        {
            List<CartViewModel> cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            _orderService.CreateOrUpdate(cart);
            HttpContext.Session.Remove("cart"); 
            return Redirect("/home/home");
        }

        [HttpGet]
        public IActionResult UpdateStatus(int id)
        {
            var order = _orderService.UpdateToShiper(id);
            
            return  new JsonResult(order);
        }
    }
}