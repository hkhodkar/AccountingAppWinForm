using Accounting.app.Accounting;
using Accounting.app.TransAction;
using Accounting.Business;
using Accounting.Utility.Convertors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.app
{
    public partial class Home : Form
    {
        public int userId = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void ShowCustomers_Click(object sender, EventArgs e)
        {
            var customerForm = new frmCustomers();
            customerForm.ShowDialog();
        }

        private void btnAddAccounting_Click(object sender, EventArgs e)
        {
            var frmNewTransAction = new frmNewTransAction();
            frmNewTransAction.ShowDialog();
        }

        private void btnPayReport_Click(object sender, EventArgs e)
        {
            var frmRep = new frmReport();
            frmRep.reportType = 1;
            frmRep.ShowDialog();
        }

        private void btnRecieveReport_Click(object sender, EventArgs e)
        {
            var frmRep = new frmReport();
            frmRep.reportType = 2;
            frmRep.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
    
            this.Hide();
            var res = Account.HomeReport();
            lblRecieve.Text = res.Receive.ToString("0,#");
            lblPays.Text = res.Pay.ToString("0,#");
            lblAccountBalance.Text = res.AccountBalance.ToString("0,#");

            var frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                lblDate.Text = DateTime.Now.ToShamsi();
                lblTime.Text = DateTime.Now.ToShortTimeString();
            }
            else
            {
                Application.Exit();
            }
        }

        private void lblTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnLoginSetting_Click(object sender, EventArgs e)
        {
            var frmLogin = new frmLogin();
            frmLogin.IsEdit = true;
            frmLogin.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

  
    }
}
