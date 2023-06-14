using CryptoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Web;

namespace CryptoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoController : ControllerBase
    {
        private IConfiguration _configuration;
        private string listaCoins;
        private string apiKey;
        private string apiUrl;
        private static readonly HttpClient client = new HttpClient();

        public CryptoController(IConfiguration configuration)
        {
            _configuration = configuration;
            listaCoins = _configuration.GetSection("Coins").Get<string>();
            apiKey = _configuration.GetSection("CoinMarketCapKey").Get<string>();
            apiUrl = _configuration.GetSection("CoinMarketApiUrl").Get<string>();
        }

        [HttpGet]
        public async Task<IEnumerable<CotizacionDto>> GetCotizaciones(float importeUsd)
        {

            List<CotizacionDto> listaCotizaciones = new List<CotizacionDto>();
            var url = new UriBuilder(apiUrl);

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["slug"] = listaCoins;

            url.Query = queryString.ToString();

            client.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", apiKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(url.ToString());

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {response.StatusCode}");                
            }

            var result = await response.Content.ReadFromJsonAsync<Response>();

            if (result == null)
            {
                return new List<CotizacionDto>();               
            }

            foreach (var item in result.Data)
            {
                listaCotizaciones.Add(new CotizacionDto { valor = item.Value.Quote.USD.Price * importeUsd, cryptomoneda = item.Value.Slug.ToUpper() });//.Symbol
            }
            return listaCotizaciones;

        }


    }
}
