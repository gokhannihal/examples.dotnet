using dotnetExamples.Attribute.WebApi.Models;

namespace dotnetExamples.Attribute.WebApi.Services;

public class TenantUserService
{
    // todo Tenant Name Required
    // go db and get Tentant users
    public IEnumerable<Users> GetAllUsers()
    {
        return new List<Users>(){
            new Users(){ Id=1 , EmailAddress="gokhan.nihal@outlook.com.tr"}
        };
    }
}
