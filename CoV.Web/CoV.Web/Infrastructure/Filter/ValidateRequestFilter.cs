using Microsoft.AspNetCore.Mvc.Filters;

namespace CoV.Web.Infrastructure.Filter
{
    public class ValidateRequestFilter : ActionFilterAttribute
    {
        private string _bodyAsText;

        public ValidateRequestFilter()
        {

        }

        /// <summary>
        /// Called before the action method is invoked.
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {

        }

        /// <summary>
        /// Called after the action method is invoked.
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}