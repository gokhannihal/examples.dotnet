using dotnetExamples.Attribute.WebApi.Extensions;
using dotnetExamples.Attribute.WebApi.Models;
using Microsoft.AspNetCore.Mvc.Filters;


namespace dotnetExamples.Attribute.WebApi.ActionFilters;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public class RequireTenantNameAttribute : ActionFilterAttribute
{
    public RequireTenantNameAttribute(string headerkey = "TenantName")
    {
        this.headerkey = headerkey;
    }
    private readonly string headerkey;
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if(!context.ActionDescriptor.FilterDescriptors.Any(i => i.Filter.GetType() == typeof(RequireTenantNameAttribute)))
            return;

        var header = context.HttpContext.Request.Headers;

        if(header is null || !header.Any() || !header.ContainsKey(headerkey)) {
            throw new MissingTenantNameException();
        }

        var tenantName = header[headerkey].ToString();

        var tenanModel = context.HttpContext.RequestServices.GetService(typeof(TenantModel)) as TenantModel;

        tenanModel.Name = tenantName;
        //context.ActionArguments["tenantName"] = tenantName; // tenanatName parametresi tenantController içerisindeki Get Method 'una gönderilmese bile bu şekilde parametre Action 'a aktarılmış olacak.

    }
}
