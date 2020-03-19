using System;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using CoV.Common.Infrastructure;
using CoV.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoV.Web.Infrastructure.Filter
{
    public class ExpireDateUserFilter : IActionFilter
    {
        /// <summary>
        /// relare User Service
        /// </summary>
        private readonly IUserService _userService;
        
        
        /// <summary>
        /// Controller
        /// </summary>
        /// <param name="userService"></param>
        public ExpireDateUserFilter(IUserService userService )
        {
            _userService = userService;
        }
        
        /// <summary>
        /// Method On Acction Executing
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuting(ActionExecutingContext context )
        { 
            // Do something before the action executes
            var httpContext = context.HttpContext;
            var name = httpContext.User.Identity.Name;
            var user = _userService.GetByName(name);
            if (user.ExpiredDate <= DateTime.Now)        
            {
                context.Result = new ViewResult
                {
                    ViewName = "FilterExpired"
                };
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.
        }
        
        
    }
}