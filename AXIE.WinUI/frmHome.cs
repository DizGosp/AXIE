using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AXIE.WinUI.Account;

namespace AXIE.WinUI
{
    public partial class frmHome : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        public frmHome()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;
            pnlNav.Left = btnAccount.Left;
            btnAccount.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;
            pnlNav.Left = btnAccount.Left;
            btnAccount.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Account";
            this.pnlFormLoader.Controls.Clear();
            frmAccountList frmAccounts = new frmAccountList()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            frmAccounts.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAccounts);
            frmAccounts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnNft.Height;
            pnlNav.Top = btnNft.Top;
            pnlNav.Left = btnNft.Left;
            btnNft.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;
            pnlNav.Left = btnAccount.Left;
            btnAccount.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Account";
            this.pnlFormLoader.Controls.Clear();
            frmAccountList frmAccounts = new frmAccountList()
            {
                Dock = DockStyle.Fill,
                TopLevel=false,
                TopMost=true
            };

            frmAccounts.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAccounts);
            frmAccounts.Show();
        }

        private void btnSchool_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSchool.Height;
            pnlNav.Top = btnSchool.Top;
            pnlNav.Left = btnSchool.Left;
            btnSchool.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAccount_Leave(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnNft_Leave(object sender, EventArgs e)
        {
            btnNft.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSchool_Leave(object sender, EventArgs e)
        {
            btnSchool.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
