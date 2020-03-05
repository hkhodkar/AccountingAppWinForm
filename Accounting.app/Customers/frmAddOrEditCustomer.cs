using Accounting.DataLayer.Context;
using Accounting.DataLayer.Context.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.app
{
    public partial class frmAddOrEditCustomer : Form
    {
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
                    uof.CustomerRepository.InsertCustomers(customer);
                    uof.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}
