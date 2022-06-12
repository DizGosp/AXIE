using AXIE.API.Interfaces;
using AXIE.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIE.API.IoC
{
    public static class DependencyConteiner
    {
        public static IApiEnviromentService GetEnviroment()
        {
            return new ApiEnviromentService();
        }
    }
}
