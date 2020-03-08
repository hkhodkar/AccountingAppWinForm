using Accounting.DataLayer.Context.UnitOfWorks;
using System;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.app.Accounting
{
    public partial class frmNewTransAction : Form
    {
        public int accountingId = 0;

        public frmNewTransAction()
        {
            InitializeComponent();
        }

        private void frmNewTransAction_Load(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWorks())
            {
                dgvTransAction.AutoGenerateColumns = false;
                dgvTransAction.DataSource = uow.CustomerRepository.GetCustomerNames();
                if (accountingId != 0)
                {
                    var data = uow.AccountingRepo.GetById(accountingId);
                    this.txtAmount.Text = data.Amount.ToString();
                    this.txtDescription.Text = data.AccountingDescription.ToString();
                    this.txtCustomerName.Text = uow.CustomerRepository.GetCustomerNameById(data.CustomerID_Cus);
                    if (accountingId == 1)
                    {
                        rbPayment.Checked = true;
                    }
                    else
                    {
                        rbRecieve.Checked = true;
                    }
                    this.Text = "ویرایش";
                }
            }


        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWorks())
            {
                dgvTransAction.AutoGenerateColumns = false;
                dgvTransAction.DataSource = uow.CustomerRepository.GetCustomerNames(txtFilter.Text);
            }
        }

        private void dgvTransAction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = dgvTransAction.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPayment.Checked || rbRecieve.Checked)
                {
                    var accounting = new DataLayer.Context.Accounting()
                    {
                        CustomerID_Cus = int.Parse(dgvTransAction.CurrentRow.Cells[1].Value.ToString()),
                        AccountingDescription = txtDescription.Text,
                        TypeID_typ = (rbRecieve.Checked) ? 2 : 1,
                        Amount = txtAmount.Text.ToString(),
                        CreationDate = DateTime.Now
                    };
                    using (var uow = new UnitOfWorks())
                    {
                        if (accountingId == 0)
                        {
                            uow.AccountingRepo.Insert(accounting);
                        }
                        else
                        {
                            accounting.AccountigID = accountingId;
                            uow.AccountingRepo.Update(accounting);
                        }
                        uow.Save();
                    };
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
                }
            }
        }
    }
}
