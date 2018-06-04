using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataVizAngular.Model
{
    public class Dataset
    {
        public List<List<object>> Data { get; set; }


        public List<Price> ToPrices()
        {
            List<Price> p = new List<Price>();
            foreach (var item in Data)
            {
                p.Add(new Price
                {
                    date = item[0].ToString(),
                    Open = double.Parse(item[1].ToString()),
                    High = double.Parse(item[2].ToString()),
                    Low = double.Parse(item[3].ToString()),
                    Close = double.Parse(item[4].ToString()),
                    Volume = double.Parse(item[5].ToString()),
                    ExDividend = double.Parse(item[6].ToString()),
                    SplitRatio = double.Parse(item[7].ToString()),
                    AdjOpen = double.Parse(item[8].ToString()),
                    AdjHigh = double.Parse(item[9].ToString()),
                    AdjLow = double.Parse(item[10].ToString()),
                    AdjClose = double.Parse(item[11].ToString()),
                    AdjVolume = double.Parse(item[12].ToString())
                });
            }
            return p;
        }
    }
}
