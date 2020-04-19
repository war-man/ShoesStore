using System;
using CoV.Common.Resources;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace CoV.Web.Controllers
{
    public class ErrorController : Controller
    {
        
        
        /// <summary>
        ///  error 404
        /// </summary>
        /// <returns>view</returns>
        [HttpGet]
        public IActionResult pagenotfound()
        {
            try
            {
                Log.Error(MessageResource.errer404);
                return
                 View();
            }
            catch (Exception e)
            {
                Log.Error(MessageResource.errer404 + e);
                throw;
            }
            return
            View();
        }
        
        /// <summary>
        /// eror 500
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult systemerror()
        {
            try
            {
                Log.Error(MessageResource.error500);
                return
                    View();
            }
            catch (Exception e)
            {
                
                Log.Error(MessageResource.error500 + e  );
                throw;
            }
        }
    
        /// <summary>
        /// Error Assessdenief
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult accessdenied()
        {
            try
            {
                Log.Error(MessageResource.error401);
                return View();
            }
            catch (Exception e)
            {
                Log.Error(MessageResource.error401 + e);
                throw;
            }
        }

 
    }
}