using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataVizAngular.Services;

namespace DataVizAngular.Controllers
{
    [Produces("application/json")]
    [Route("api/Price")]
    public class PriceController : Controller
    {
        private IPricesService _PricesService;
        public PriceController(IPricesService PricesService)
        {
            _PricesService = PricesService;
        }
        //String url = "https://www.quandl.com/api/v3/datasets/WIKI/AAPL.json";
        //String apiKey = "DKczFdjuL_16KZVxeZKk";
        //String startDate = "1985-05-01";
        //String endDate = "1997-07-01";
        //String limit = "5";
        //String order = "asc";
        //String collapse = "quarterly";
        //String transformation = "rdiff";

        [HttpGet("GetPrices/{startDate}/{endDate}/{limit}/{order}/{collapse}/{transformation}")]
        public async Task<object> GetPrices(string  startDate, string endDate, string limit, string order, string collapse, string transformation)
        {
          return await _PricesService.getPrices(  startDate,  endDate,   limit,   order,   collapse,   transformation);
         // return await _PricesService.getPrices("2017-05-01", "2018-05-01", "5", "asc", "quarterly", "rdiff");
        }
    }
}