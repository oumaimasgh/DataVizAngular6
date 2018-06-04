using DataVizAngular.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataVizAngular.Services
{
    public interface IPricesService
    {
        Task<IList<Price>> getPrices(string startDate, string endDate, string limit, string order, string collapse, string transformation);
    }
}