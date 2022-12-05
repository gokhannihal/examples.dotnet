using dotnetExamples.Attribute.WebApi.ActionFilters;
using dotnetExamples.Attribute.WebApi.Models;
using dotnetExamples.Attribute.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetExamples.Attribute.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[RequireTenantName(headerkey:"TenantName")]

public class TenantController : ControllerBase
{
    private readonly TenantUserService tenantUserService;
    private readonly TenantModel tenantModel;
    public TenantController(TenantUserService tenantUserService, TenantModel tenantModel)
    {
        this.tenantUserService = tenantUserService;
        this.tenantModel = tenantModel;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var users = tenantUserService.GetAllUsers(tenantModel.Name);

        return Ok(users);
    }

}
