using Microsoft.EntityFrameworkCore;
using poc.SearchCity.Api.Data.Entities;
using poc.SearchCity.Api.Helpers;

namespace poc.SearchCity.Api.Data.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _context;

        public CityRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetAllCitiesAsync(CancellationToken cancellationToken)
        {
            return await _context.Cities.Take(10).ToListAsync();
        }

        public async Task<IEnumerable<City>> GetCitiesByStateAndNameAsync(int stateId, string name, CancellationToken cancellationToken)
        {
            var normalizedName = StringHelper.Normalizestring(name);

            var cities = await _context.Cities.Where(c => c.estado_id == stateId).ToListAsync(cancellationToken);

            var filteredCities = cities.Where(c => StringHelper.Normalizestring(c.Nome).Contains(normalizedName, StringComparison.OrdinalIgnoreCase));

            return filteredCities;
        }
    }
}
