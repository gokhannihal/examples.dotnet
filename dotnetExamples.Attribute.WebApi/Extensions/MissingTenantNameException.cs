namespace dotnetExamples.Attribute.WebApi.Extensions
{
    public class MissingTenantNameException : Exception
    {
        public MissingTenantNameException():base(message: "TenantName must be provided via header") { 
        }

    }
}
