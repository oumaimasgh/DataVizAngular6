using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace DataVizAngular.Services
{
    public class HttpHelperService : IHttpHelperServicecs
    {
        private readonly HttpClient _httpClient;


        public HttpHelperService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://www.quandl.com/api/v3/datasets/WIKI/AAPL.json"), Timeout = TimeSpan.FromMinutes(15) };
            
        }
        public async Task<string> Get(Dictionary<string, string> param)
        {
            var api = BuildURLParametersString(param);
            var response = await _httpClient.GetAsync(api);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return null;
        }

        private String BuildURLParametersString(Dictionary<string, string> parameters)
        {
            UriBuilder uriBuilder = new UriBuilder();
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            foreach (var urlParameter in parameters)
            {
                query[urlParameter.Key] = urlParameter.Value;
            }
            uriBuilder.Query = query.ToString();
            return uriBuilder.Query;
        }
    }
}
