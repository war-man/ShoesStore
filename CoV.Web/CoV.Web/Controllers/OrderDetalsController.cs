using System.Linq;
using CoV.Service.Service;
using GreenWhale.Alipay.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class OrderDetalsController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IProductDetailsService  _productDetailsService;
        private readonly IOrderDetailsService  _orderDetailsService;

        public OrderDetalsController(IOrderService orderService, IProductService productService,IOrderStatusService orderStatusService, IProductDetailsService productDetailsService, IOrderDetailsService orderDetailsService)
        {
            _orderService = orderService;
            _productService = productService;
            _productDetailsService = productDetailsService;
            _orderDetailsService = orderDetailsService;
        }
        // GET
        public IActionResult Index()
        {
            var orderdetails = _orderDetailsService.GetAll().Where(c=>c.StatusId ==1 || c.StatusId == 5).ToList();
            return 
            View(orderdetails);
        }
        
        /// <summary>
        /// Giao thanh công
        /// </summary>
        /// <returns></returns>
        public IActionResult Ferfect()
        {
            var orderdetails = _orderDetailsService.GetAll().Where(c=>c.StatusId == 3 ).ToList();
            return 
                View(orderdetails);
        }
        
        /// <summary>
        /// Dang giao
        /// </summary>
        /// <returns></returns>
        public IActionResult Loading()
        {
            var orderdetails = _orderDetailsService.GetAll().Where(c=>c.StatusId == 4 ).ToList();
            return 
                View(orderdetails);
        }
        
        public IActionResult Return()
        {
            var orderdetails = _orderDetailsService.GetAll().Where(c=>c.StatusId == 2 ).ToList();
            return 
                View(orderdetails);
        }
        
        /// <summary>
        /// Delete Product 
        /// </summary>
        /// <param name="id"></param>
        public IActionResult Delete(int id)
        {
            _orderDetailsService.Delete(id);
            return new JsonResult("a");
        }
        
        /// <summary>
        /// update Status nhan hang
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult UpdateStatus(int id)
        {
            var order = _orderDetailsService.UpdateToShiper(id);
            return  new JsonResult(order);
        }
        
        /// <summary>
        /// ship nhan hang
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ShiperNhap(int id)
        {
            var name = HttpContext.User.Identity.Name;
            var order = _orderDetailsService.UpdateShipNhan(id,name); 
            return  new JsonResult(order);
        }
        
        /// <summary>
        /// Giao hoan thanh
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ShipPerfect(int id)
        {
            var order = _orderDetailsService.ShipPerfect(id); 
            return  new JsonResult(order);
        }
        
        /// <summary>
        /// hoan hang
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Comback(int id)
        {
            _orderDetailsService.Comback(id); 
            return  Redirect("/Shiper/DangGiao");
        }
    }
}