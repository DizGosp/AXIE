using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;

namespace AXIE.WinUI.Account
{
    public partial class frmAccountList : Form
    {
        public frmAccountList()
        {
            InitializeComponent();
        }
            
        private void btnShow_Click(object sender, EventArgs e)
        {
            var result = "https://localhost:7259/api/Account".GetJsonAsync<dynamic>().Result;
        }
    }
}
