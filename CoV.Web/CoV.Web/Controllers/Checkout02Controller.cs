using System;
using System.Collections.Generic;
using CoV.Service.DataModel;
using CoV.Service.Service;
using CoV.Web.Infrastructure.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class Checkout02Controller : Controller
    {
        private readonly ICustomerService _customerService;

        public Checkout02Controller(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Checkout02()
        {
            // return cart
            var sessionName = HttpContext.Session.GetString("SessionPhone");
            var cart = SessionHelper.GetObjectFromJson<List<CartViewModel>>(HttpContext.Session, "cart");
            var cartCustomer = cart.FindAll(x => x.Name == sessionName);
            ViewBag.cart = cartCustomer;
            
            //return price
            var price = 0;
            foreach (var item in cart)
            {
                price = price + item.TotalPrice;
            }
            ViewBag.totalprice = price;
            
            // view information customer
            var sessionId = Int32.Parse(HttpContext.Session.GetString("SessionId"));
            var customer = _customerService.GetById(sessionId);
            ViewBag.customer = customer;
            return View();
        }
    }
}