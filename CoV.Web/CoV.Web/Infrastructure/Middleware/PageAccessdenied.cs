using System.Threading.Tasks;
using CoV.Common.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CoV.Web.Infrastructure.Middleware
{
    public class PageAccessdenied
    {
        private readonly RequestDelegate _next;
        
        public PageAccessdenied(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task Invoke(HttpContext context)
        {
            await _next(context);
            if (context.Response.StatusCode == StatusCodes.Status401Unauthorized && !context.Response.HasStarted)
            {
                context.Request.Path = Constants.Route.AccessDenied;
                await this._next(context);
            }
        }
    }
    public static class RequestPageAccessdenied
    {
        public static IApplicationBuilder UsePageAccessdenied(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PageAccessdenied>();
        }
    } 
}