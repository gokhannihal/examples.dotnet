
using dotnetExamples.Attribute.WebApi.ActionFilters;
using dotnetExamples.Attribute.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetExamples.Attribute.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[AdvanceLogging]
public class CountriesController : ControllerBase
{
 
    public CountriesController(CountriesService countriesService)
    {
        this._countriesService = countriesService;
    }

    public readonly CountriesService _countriesService;

    [HttpGet]
    public ActionResult GetCountries()
    {
        var countries = _countriesService.getAllCountires();
        return Ok(countries);
    }
    
}
