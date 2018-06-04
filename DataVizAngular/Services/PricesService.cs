using DataVizAngular.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DataVizAngular.Services
{
    public class PricesService : IPricesService
    {
        private IHttpHelperServicecs _httpHelperService;
        public PricesService(IHttpHelperServicecs httpHelperService)
        {
            _httpHelperService = httpHelperService;
        }
        public async Task<IList<Price>> getPrices(string startDate, string endDate, string limit, string order, string collapse, string transformation)
        {
            
            String apiKey = "DKczFdjuL_16KZVxeZKk";
            Dictionary<string, string> param = new Dictionary<string, string>();

            param.Add("api_key", apiKey);
            param.Add("transformation", transformation);
            param.Add("collapse", collapse);
            param.Add("order", order);
            param.Add("end_date", endDate);
            param.Add("start_date", startDate);
            param.Add("limit", limit);

            
            var response = await _httpHelperService.Get(param);

            if (response != null) {
                DataResult o1 = JsonConvert.DeserializeObject<DataResult>(response);
                var prices= o1.dataset.ToPrices();
                return prices;
            }
            return null;

        }
    }
}
