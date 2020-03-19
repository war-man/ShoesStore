using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Constants = CoV.Common.Infrastructure.Constants;

namespace CoV.Web.Infrastructure.Middleware
{
    public class PageNotFound
    {
        private readonly RequestDelegate _next;

        public PageNotFound(RequestDelegate next)
        {
            _next = next;
        }
        
        /// <summary>
        /// Check Page not pound  404
        /// </summary>
        /// <param name="context"></param>    
        /// <returns>Error/pagenotpound</returns>
        /// 
        public async Task Invoke(HttpContext context)
        {
            await _next(context);
            //Check Error 404
            if (context.Response.StatusCode == StatusCodes.Status404NotFound && !context.Response.HasStarted)
            {
                context.Request.Path = Constants.Route.NotFound;
                  await this._next(context);
            }

            if (context.Response.StatusCode == StatusCodes.Status400BadRequest && !context.Response.HasStarted)
            {
                context.Request.Path = Constants.Route.NotFound;
                await this._next(context);
            }
            if (context.Response.StatusCode == StatusCodes.Status500InternalServerError && !context.Response.HasStarted)
            {
                context.Request.Path = Constants.Route.ErrorPage;
                await this._next(context);
            }
        }
        
    }
    /// <summary>s
    /// use  Requestpagenotpound in Configure
    /// </summary>
    public static class RequestCultureMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestCulture(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PageNotFound>();
        }
    } 
}