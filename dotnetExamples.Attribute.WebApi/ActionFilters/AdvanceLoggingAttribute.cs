using Microsoft.AspNetCore.Mvc.Filters;

namespace dotnetExamples.Attribute.WebApi.ActionFilters
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AdvanceLoggingAttribute : ActionFilterAttribute
    {
        

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ActionDescriptor.FilterDescriptors.Any(i => i.Filter.GetType() == typeof(AdvanceLoggingAttribute)))
            {
                await next();
                return;
            }
            var _logger = context.HttpContext.RequestServices.GetService<ILogger<AdvanceLoggingAttribute>>();

            if (_logger != null)
            {
                _logger.LogInformation($"Beffore Action:{context.HttpContext.Request.Path}");
            }

            await next();

            if (_logger != null)
            {
                _logger.LogInformation($"After Action:{context.HttpContext.Response.StatusCode}");
            }
        }
    }
}
