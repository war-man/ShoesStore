using System;
using CoV.Common.Resources;
using CoV.Service.DataModel;
using CoV.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService  )
        {
            _customerService = customerService;
        }
        
        // GET
        [HttpGet]
        public IActionResult GetAll()
        {
            var Customer = _customerService.GetAll();
            return
            View(Customer);
        }

        /// <summary>
        /// Delete A customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult delete(int id)
        {
            _customerService.Delete(id);
            return RedirectToAction("GetAll");
        }
        
        [HttpGet]
        public IActionResult CreateAndUpdate()
        {
                return View();
        }
        
        /// <summary>
        ///  Create Or Update a Customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateAndUpdate(CustomerViewModel model)
        {
            var sessionEmail = HttpContext.Session.GetString("SessionEmail");
            if (sessionEmail != null)
            {
                return Redirect("/home/home");
            }
            if (model.PassWord != model.ConfiguePassWord)
            {
                ModelState.AddModelError(string.Empty, MessageResource.ConfiguePassword);
                return View();
            }
            if (_customerService.CheckAccountCustomer(model) == true) //tai khoan da ton tai
            {
                ModelState.AddModelError(String.Empty, MessageResource.LoginCustomerSingUpFailed);
                return View();
            }
            _customerService.CreateOrUpdate(model);
            return Redirect("/home/home");
        }
    
        [HttpGet]
        public IActionResult LoginCustomer()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginCustomer( loginCustomerViewModel model)
        {
            if (_customerService.CheckLoginAccountCustomer(model) == false) //tai khoan chua ton tai
            {
                ModelState.AddModelError(String.Empty, MessageResource.CustomerSingUpFailed);
                return View();
            }

            if (_customerService.CheckPass(model) == true)
            {
                var customerName = _customerService.GetByName(model.Email);
                HttpContext.Session.SetString("SessionName",customerName.LastName);
                HttpContext.Session.SetString("SessionEmail",customerName.Email);
                HttpContext.Session.SetString("SessionPhone",customerName.PhoneNumber);
                return Redirect("/home/home");
            }
            else
            {
                ModelState.AddModelError(String.Empty, MessageResource.UserLoginFailed);
            }
            return View();
        }
        
        /// <summary>
        /// Logout Customer remove Session
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult  Logout()
        {    
            HttpContext.Session.Remove("SessionEmail");
            HttpContext.Session.Remove("SessionName");
            HttpContext.Session.Remove("SessionPhone");
            return  Redirect("/Customer/LoginCustomer");
        }
    }
}