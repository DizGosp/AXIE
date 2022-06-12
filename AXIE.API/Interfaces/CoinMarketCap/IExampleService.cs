using AXIE.API.Models.CoinMarketCap.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AXIE.API.Interfaces.CoinMarketCap
{
    public interface IExampleService: IDisposable
    {
        Task<string> GetExample();
        Task<PriceResponseVM> GetExample2(Example model);
    }
}
