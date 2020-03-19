using System;
using CoV.Common.Infrastructure;
using CoV.Common.Resources;
using CoV.Service.DataModel;
using CoV.Service.Service;
using CoV.Web.Infrastructure.Filter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;


namespace CoV.Web.Controllers
{
    /// <summary>
    /// Controller Classes 
    /// </summary>
    [Authorize(Policy = Constants.Role.Admin)]
    [ServiceFilter(typeof(ExpireDateUserFilter))]
    public class ClassesController : Controller
    {
        private readonly IClassesService _ClassService;   
        
        /// <summary>
        /// Contructor ClassesController
        /// </summary>
        /// <param name="classService"></param>
        public ClassesController(IClassesService classService)
        {
            _ClassService = classService;
        }
        
        /// <summary>
        /// show class
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Show()
        {
            var classer = _ClassService.GetAll();
            return
            View(classer);
        }
        
        /// <summary>
        ///  view create class
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateClass()
        {
            return View();
        }
        
        /// <summary>
        ///  funtion  create class
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateClass(CreateClasserModel createClass)
        {
            try
            {
                if (!ModelState.IsValid) return View();
                _ClassService.CreaterClass(createClass);
                Log.Information("CreateSuccess: " , createClass);
                return Redirect("/Classes/Show");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// delete a Entity Classer for Id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult DeleteClass(int id)
        {
            _ClassService.Delete(id);
            return Redirect("/Classes/Show");
        }
        
        /// <summary>
        /// view Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns>view</returns>
        [HttpGet]
        public IActionResult Update(int id)
        {
            var classes = _ClassService.GetById(id);
            return View(classes);
        }
        
        /// <summary>
        ///  Update claseer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]     
        public IActionResult Update(CreateClasserModel model)
        {
            _ClassService.Update(model);
            return Redirect("/Classes/Show");
        }
    }
}