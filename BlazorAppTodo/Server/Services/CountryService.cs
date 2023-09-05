using BlazorAppTodo.Server.Models;
using BlazorAppTodo.Server.Repository;

namespace BlazorAppTodo.Server.Services
{
    public class CountryService : ICountryService
    {
        private readonly IRepository<Country> _country;
        public CountryService(IRepository<Country> country)
        {
            _country = country;
        }
        public async Task<Country> AddCountry(Country country)
        {
            return await _country.CreateAsync(country);
        }

        public async Task<bool> UpdateCountry(int id, Country country) 
        {
            var data = await _country.GetByIdAsync(id);

            if (data != null)
            {  
                data.CountryName = country.CountryName;
                data.ISOCodeAlpha2 = country.ISOCodeAlpha2;
                data.CountryCode = country.CountryCode;

                await _country.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }

        public async Task<bool> DeleteCountry(int id)
        {
            await _country.DeleteAsync(id);
            return true;
        }

        public async Task<List<Country>> GetAllCountries()
        {
            return await _country.GetAllAsync();
        }

        public async Task<Country> GetCountry(int id)
        {
            return await _country.GetByIdAsync(id);
        }
    }
}
