using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AXIE.Models.Account;
using Flurl.Http;
using Newtonsoft.Json;

namespace AXIE.WinUI.Account
{
    public partial class frmAccountList : Form
    {
        private readonly ApiService _apiService = new ApiService("Account");
        public frmAccountList()
        {
            InitializeComponent();
        }
            
        private async void btnShow_Click(object sender, EventArgs e)
        {
            var listAccounts =await _apiService.Get<List<AccountDTO>>();

            dgvAccountList.AutoGenerateColumns = false;
            dgvAccountList.DataSource = listAccounts;

        }

        private async void frmAccountList_Load(object sender, EventArgs e)
        {
            var listAccounts = await _apiService.Get<List<AccountDTO>>();

            dgvAccountList.AutoGenerateColumns = false;
            dgvAccountList.DataSource = listAccounts;
        }
    }
}
