using poc.SearchCity.Api.Data.Entities;

namespace poc.SearchCity.Api.Data.Repositories
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetAllCitiesAsync(CancellationToken cancellationToken);
        Task<IEnumerable<City>> GetCitiesByStateAndNameAsync(int stateId, string name, CancellationToken cancellationToken);
    }
}
