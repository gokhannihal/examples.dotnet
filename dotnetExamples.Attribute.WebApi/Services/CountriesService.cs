using dotnetExamples.Attribute.WebApi.Models;

namespace dotnetExamples.Attribute.WebApi.Services;

public class CountriesService
{
   public IEnumerable<CountryModel> getAllCountires()
   {

        return new List<CountryModel>() {
            new CountryModel(){Name="Türkiye"},
            new CountryModel(){Name="Franca"},
            new CountryModel(){Name="Polonya"}
        };
    
   }
}
