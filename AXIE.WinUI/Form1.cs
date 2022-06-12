using AXIE.API.Interfaces.CoinMarketCap;
using AXIE.API.Models.CoinMarketCap.Example;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AXIE.WinUI
{
    public partial class Form1 : Form
    {
        private readonly IExampleService _service;
        public Form1(IExampleService service)
        {
            _service = service;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            PriceResponseVM result =await _service.GetExample2(new Example { ids= "starsharks", vs_currencies=txtMoney.Text});

            if (txtMoney.Text.ToLower() == "eur")
            {
                lblAXS.Text = result.axieInfinity.eur.ToString() + " EUR";
                lblSEA.Text = result.starsharksSea.eur.ToString() + " EUR";
                lblSLP.Text = result.smoothLovePotion.eur.ToString() + " EUR";
                lblBT.Text = result.cyblocBatteryToken.eur.ToString() + " EUR";
                lblVIS.Text = result.vigorus.eur.ToString() + " EUR";
                lblTUS.Text = result.treasureUnderSea.eur.ToString() + " EUR";
            }
            else
            {
                lblAXS.Text = result.axieInfinity.usd.ToString() + " USD";
                lblSEA.Text = result.starsharksSea.usd.ToString() + " USD";
                lblSLP.Text = result.smoothLovePotion.usd.ToString() + " USD";
                lblBT.Text = result.cyblocBatteryToken.usd.ToString() + " USD";
                lblVIS.Text = result.vigorus.usd.ToString() + " USD";
                lblTUS.Text = result.treasureUnderSea.usd.ToString() + " USD";
            }
        }
    }
}
