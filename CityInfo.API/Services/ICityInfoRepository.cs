using CityInfo.API.Entities;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();
        // or
        // IQueryable<City> GetCities(); This allows one to build on the query when needed, but can violate the repository pattern idea. Many flamewars ensure.

        Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest);

        Task<bool> CityExistsAsync(int cityId)
        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCityAsync(int cityId);
        Task<PointOfInterest?> GetPointOfInterestForCityAsync(int cityId, int pointOfInterestId);
    }
}
