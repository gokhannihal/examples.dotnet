using dotnetExamples.Attribute.WebApi;
using dotnetExamples.Attribute.WebApi.ActionFilters;
using dotnetExamples.Attribute.WebApi.Models;
using dotnetExamples.Attribute.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(conf =>
{
    conf.Filters.Add<RequireTenantNameAttribute>();
    conf.Filters.Add<AdvanceLoggingAttribute>();
}
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.AddSingletonService();
builder.Services.AddScoped<TenantModel>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
