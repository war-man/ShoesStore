using System.Net;
using AutoMapper.Configuration;
using CoV.Common.Infrastructure;
using CoV.Web.Infrastructure.Exceptions;
using log4net.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;

namespace CoV.Web.Infrastructure.Filter
{
//    public class HttpGlobalExceptionFilter : IExceptionFilter
//    {
//        private readonly IHostingEnvironment _env;
//        private readonly ILogger _logger;
//        private readonly IConfiguration _configuration;
//
//        /// <summary>
//        /// Constructor for Class
//        /// </summary>
//        /// <param name="env"></param>
//        /// <param name="logger"></param>
//        /// <param name="configuration"></param>
//        public HttpGlobalExceptionFilter(IHostingEnvironment env,
//            ILogger<HttpGlobalExceptionFilter> logger, IConfiguration configuration)
//        {
//            _env = env;
//            _logger = logger;
//            _configuration = configuration;
//        }
//
//        /// <inheritdoc />
//        /// <summary>
//        /// On Exception Class
//        /// </summary>
//        /// <param name="context"></param>
//        public void OnException(ExceptionContext context)
//        {
//            _logger.LogError(new EventId(context.Exception.HResult),
//                context.Exception,
//                context.Exception.Message);
//
//            if (context.Exception.GetType() == typeof(ApiDomainException))
//            {
//                var json = new JsonErrorResponse
//                {
//                    Messages = new[] {context.Exception.Message}
//                };
//
//                context.Result = new BadRequestObjectResult(json);
//                context.HttpContext.Response.StatusCode = (int) HttpStatusCode.BadRequest;
//            }
//            else
//            {
//                var json = new JsonErrorResponse
//                {
//                    Messages = new[] {_configuration[Constants.Settings.ErrorMessage] }
//                };
//
//                if (_env.IsDevelopment())
//                {
//                    json.DeveloperMeesage = context.Exception;
//                }
//
//                context.Result = new InternalServerErrorObjectResult(json);
//                context.HttpContext.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
//            }
//            context.ExceptionHandled = true;
//        }
//
//        /// <summary>
//        /// Json Error Response Class
//        /// </summary>
//        private class JsonErrorResponse
//        {
//            public string[] Messages { get; set; }
//
//            public object DeveloperMeesage { get; set; }
//        }
//    }
}