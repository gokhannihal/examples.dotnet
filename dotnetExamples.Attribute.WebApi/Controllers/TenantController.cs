using dotnetExamples.Attribute.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetExamples.Attribute.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TenantController : ControllerBase
{
    private readonly TenantUserService tenantUserService;

    public TenantController(TenantUserService tenantUserService)
   {
        this.tenantUserService = tenantUserService;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var users = tenantUserService.GetAllUsers();

        return Ok(users);
    }

}
