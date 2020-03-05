using Accounting.DataLayer.Context.UnitOfWorks;
using System;
using System.Windows.Forms;

namespace Accounting.app
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            BindGrid();
        }

        private void BindGrid()
        {

            using (var uow = new UnitOfWorks())
            {
                dgvCustomer.DataSource = uow.CustomerRepository.GettAll();
            }
        }

        private void FilterCustomer_TextChanged(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWorks())
            {
                dgvCustomer.DataSource = uow.CustomerRepository.FilterdCustomer(TxtFilter.Text);
            }
        }

        private void RefreshGrid_Click(object sender, EventArgs e)
        {
            TxtFilter.Text = "";
            BindGrid();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            var frmAddCustomer = new frmAddOrEditCustomer();
            if (frmAddCustomer.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            };
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                using (var uow = new UnitOfWorks())
                {
                    var name = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید؟"
                                        , "توجه"
                                        , MessageBoxButtons.YesNo
                                        , MessageBoxIcon.Warning) == DialogResult.Yes
                                       )
                    {
                        int customerId = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString());
                        uow.CustomerRepository.Delete(customerId);
                        uow.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید");
            }
        }

        private void EditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                var customerID = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString());
                var frmaddOrEditCustomer = new frmAddOrEditCustomer();
                frmaddOrEditCustomer.customerID = customerID;
                if (frmaddOrEditCustomer.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا شخصی را انتخاب نمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }
    }
}
