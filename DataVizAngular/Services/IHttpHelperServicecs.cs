using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataVizAngular.Services
{
    public interface IHttpHelperServicecs
    {
        Task<string> Get(Dictionary<string, string> param);
    }
}
