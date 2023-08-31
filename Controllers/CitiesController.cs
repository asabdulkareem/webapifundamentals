using emptyproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace emptyproject.Controllers;
[ApiController]
public class CitiesController : ControllerBase
{
    [HttpGet]
    [Route("api/cities")]
    public JsonResult  GetCities()
    {
        return new JsonResult(CitiesDataStore.Current.Cities);
    }
    [HttpGet]
    [Route("api/cities/{id}")]
    public ActionResult<CityDto> GetCity(int id)
    {
        var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
        if(cityToReturn == null)
           return NotFound();
        else
            return Ok(cityToReturn);
    }
}