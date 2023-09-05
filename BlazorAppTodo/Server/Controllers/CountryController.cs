using BlazorAppTodo.Server.Models;
using BlazorAppTodo.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppTodo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<List<Country>> GetAll()
        {
            return await _countryService.GetAllCountries();
        }

        [HttpGet("{id}")]
        public async Task<Country> Get(int id)
        {
            return await _countryService.GetCountry(id);
        }

        [HttpPost]
        public async Task<Country> AddCountry([FromBody] Country country)
        {
           return await _countryService.AddCountry(country);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteCountry(int id)
        {
            await _countryService.DeleteCountry(id); return true;
        }

        [HttpPut("{id}")]
        public async Task<bool> UpdateCountry(int id, [FromBody] Country Object)
        {
            await _countryService.UpdateCountry(id, Object); return true;
        }
    }
}
