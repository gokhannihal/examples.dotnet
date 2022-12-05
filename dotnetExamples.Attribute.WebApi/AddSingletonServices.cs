using dotnetExamples.Attribute.WebApi.Services;

namespace dotnetExamples.Attribute.WebApi
{
    public static class AddSingletonServices
    {
        public static WebApplicationBuilder AddSingletonService(this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<CountriesService>();
            builder.Services.AddSingleton<TenantUserService>();
            return builder;
        }
    }
}
