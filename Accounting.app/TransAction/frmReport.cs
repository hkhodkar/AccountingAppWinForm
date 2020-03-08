using Accounting.app.Accounting;
using Accounting.DataLayer.Context.UnitOfWorks;
using Accounting.Utility.Convertors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ViewModels.Customers;

namespace Accounting.app.TransAction
{
    public partial class frmReport : Form
    {
        public int reportType = 0;

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
     
            
            using(var uow = new UnitOfWorks())
            {
                List<CustomersViewModel> list = new List<CustomersViewModel>();
                list.Add(new CustomersViewModel
                {
                    CustomerID = 0,
                    FullName = "انتخاب کنید"
                });
                list.AddRange(uow.CustomerRepository.GetCustomerNames());
                cbCustomers.DataSource = list;
                cbCustomers.DisplayMember = "FullName";
                cbCustomers.ValueMember = "CustomerID";
            }

            if (reportType == 1)
            {
                this.Text = "گزارش های پرداختی ها";
            }
            else
            {
                this.Text = "گزارش های دریافتی ها";
            }
        }



        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            using (var uow = new UnitOfWorks())
            {
                List<DataLayer.Context.Accounting> result = new List<DataLayer.Context.Accounting>();
                DateTime? startDate;
                DateTime? endDate;


                if ((int) cbCustomers.SelectedValue !=0)
                {
                    var customerID = int.Parse(cbCustomers.SelectedValue.ToString());
                    result.AddRange(uow.AccountingRepo.GetAll(a => a.TypeID_typ == reportType && a.CustomerID_Cus == customerID));
                }
                else
                {
                    result.AddRange(uow.AccountingRepo.GetAll(a => a.TypeID_typ == reportType));
                }

                if (txtFromDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtFromDate.Text);
                    startDate = Convertors.ToMiladi(startDate.Value);
                    result = result.Where(r => r.CreationDate.Date >= startDate.Value.Date).ToList();
                }

                if (txtToDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txtToDate.Text);
                    endDate = Convertors.ToMiladi(endDate.Value);
                    var sss = endDate.Value.Date;
                    result = result.Where(r => r.CreationDate.Date <= endDate.Value.Date).ToList();
                }

                //dgvReport.DefaultCellStyle.SelectionBackColor = dgvReport.DefaultCellStyle.BackColor;
                //dgvReport.DefaultCellStyle.SelectionForeColor = dgvReport.DefaultCellStyle.ForeColor;
                //dgvReport.AutoGenerateColumns = false; 
                //dgvReport.DataSource = result;
                dgvReport.Rows.Clear();
                foreach (var item in result)
                {
                    var customerName = uow.CustomerRepository.GetCustomerNameById(item.CustomerID_Cus);
                    dgvReport.Rows.Add(item.AccountigID, customerName, item.Amount.ShowMoney(), item.CreationDate.ToShamsi(), item.AccountingDescription);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                var id = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var uow = new UnitOfWorks())
                    {
                        uow.AccountingRepo.Delete(id);
                        uow.Save();
                        Filter();
                    }
                }


            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                var id = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                var frmNewAccount = new frmNewTransAction();
                frmNewAccount.accountingId = id;
                if (frmNewAccount.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");
            foreach(DataGridViewRow item in dgvReport.Rows)
            {
                dtPrint.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()
                    );
            }
            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT", dtPrint);
            stiPrint.Show();
        }
    }
}
