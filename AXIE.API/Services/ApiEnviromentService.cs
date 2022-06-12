using AXIE.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIE.API.Services
{
    public class ApiEnviromentService : IApiEnviromentService
    {
        public string RootUrl => $"https://api.coingecko.com";
    }
}
