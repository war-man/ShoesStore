using System;
using System.Security.Claims;
using CoV.Service.Service;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoV.Web.Infrastructure.Filter
{
    public class MySampleActionFilter : IActionFilter
    {
        /// <summary>
        /// relare User Service
        /// </summary>
        private readonly IUserService _userService;
        
        /// <summary>
        /// Controller
        /// </summary>
        /// <param name="userService"></param>
        public MySampleActionFilter(IUserService userService )
        {
            _userService = userService;
        }
        
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Do something before the action executes.
           
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.
        }
    }
}