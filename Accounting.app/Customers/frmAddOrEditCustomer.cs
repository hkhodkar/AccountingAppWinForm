using Accounting.DataLayer.Context;
using Accounting.DataLayer.Context.UnitOfWorks;
using System;
using System.IO;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.app
{
    public partial class frmAddOrEditCustomer : Form
    {
        public int customerID = 0;
        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                string imagePath = Application.StartupPath + "/Images/Customers/";
                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }
                pcCustomer.Image.Save(imagePath + imageName);
                Customers customer = new Customers()
                {
                    FullName = txtFullName.Text.ToString(),
                    Email = txtEmail.Text.ToString(),
                    CustomerAddress = txtAddress.Text.ToString(),
                    CustomerImage = imageName,
                    Mobile = txtMobile.Text.ToString()
                };
                using (var uof = new UnitOfWorks())
                {
                    if (customerID == 0)
                    {
                        uof.CustomerRepository.InsertCustomers(customer);
                    }
                    else
                    {
                        customer.CustomerID = customerID;
                        uof.CustomerRepository.Update(customer);
                    }
                    uof.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerID != 0)
            {
                this.Text = "ویرایش شخص";
                this.btnSave.Text = "ویرایش";

                using (var uow = new UnitOfWorks())
                {
                    var customer = uow.CustomerRepository.GetById(customerID);
                    txtFullName.Text = customer.FullName;
                    txtMobile.Text = customer.Mobile;
                    txtEmail.Text = customer.Email;
                    txtAddress.Text = customer.CustomerAddress;
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/Customers/" + customer.CustomerImage;
                }
            }
        }
    }
}
