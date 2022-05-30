using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIE.WinUI
{
    public class ApiService
    {
        private string _route = null;

        public ApiService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>()
        {
            var result =await $"{Properties.Settings.Default.APIUrl}/{_route}".GetJsonAsync<T>();

            return result;
        }
    }
}
