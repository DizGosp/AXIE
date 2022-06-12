using AXIE.API.Interfaces.CoinMarketCap;
using AXIE.API.Services;
using AXIE.API.Services.CoinMarketCap;
using AXIE.WinUI.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AXIE.WinUI
{
    internal static class Program
    {
        private static IExampleService service = new ExampleService(new ApiEnviromentService());

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(service));
        }
    }
}
