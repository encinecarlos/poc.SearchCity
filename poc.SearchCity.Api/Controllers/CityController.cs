using Microsoft.AspNetCore.Mvc;
using poc.SearchCity.Api.Data.Repositories;

namespace poc.SearchCity.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;

        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCities()
        {
            var cities = await _cityRepository.GetAllCitiesAsync(new CancellationToken());

            if (cities == null) 
            {
                return NotFound();
            }

            return Ok(cities);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetCitiesByStateAndName(int stateId, string name)
        {
            var cities = await _cityRepository.GetCitiesByStateAndNameAsync(stateId, name, new CancellationToken());

            if (cities == null) 
            {
                return NotFound();
            }

            return Ok(cities);
        }
    }
}
