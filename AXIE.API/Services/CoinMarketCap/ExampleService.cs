using AXIE.API.Interfaces;
using AXIE.API.Interfaces.CoinMarketCap;
using AXIE.API.Models.CoinMarketCap.Example;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AXIE.API.Services.CoinMarketCap
{
    public class ExampleService : IExampleService
    {
        private readonly IApiEnviromentService _apiEnvironmentService;

        public ExampleService(IApiEnviromentService apiEnvironmentService)
        {
            _apiEnvironmentService = apiEnvironmentService;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetExample()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(_apiEnvironmentService.RootUrl);
                client.Timeout = new System.TimeSpan(0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage result = await client.GetAsync($"/api/v3/ping");

                if (result.IsSuccessStatusCode == false)
                    return null;

                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                    return null;

                return await result.Content.ReadAsStringAsync();
            }
        }

        public async Task<PriceResponseVM> GetExample2(Example request)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(_apiEnvironmentService.RootUrl);
                client.Timeout = new System.TimeSpan(0, 1, 0);
                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                HttpResponseMessage result = await client.GetAsync($"/api/v3/simple/price?ids=smooth-love-potion%2Cstarsharks-sea%2Ccybloc-battery-token%2Cvigorus%2Ctreasure-under-sea%2Caxie-infinity&vs_currencies="+request.vs_currencies);

                if (result.IsSuccessStatusCode == false)
                    return null;

                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                    return null;

                return Newtonsoft.Json.JsonConvert.DeserializeObject<PriceResponseVM>(await result.Content.ReadAsStringAsync()); ;
            }
            throw new NotImplementedException();
        }
    }
}
