using Accounting.DataLayer.Context.UnitOfWorks;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.app
{
    public partial class frmLogin : Form
    {
        public bool IsEdit = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (var uow = new UnitOfWorks())
                {
                    if (IsEdit)
                    {
                        var id = Common.Common.UserID;
                        var user  = uow.Userrepository.GetById(id);
                        user.Username = txtUsername.Text;
                        user.userPassword = txtPassword.Text;
                        uow.Userrepository.Update(user);
                        uow.Save();
                        Application.Restart();

                    }
                    else
                    {
                        if (uow.Userrepository.GetAll(l => l.Username == txtUsername.Text && l.userPassword == txtPassword.Text).Any())
                        {
                            Common.Common.UserID = uow.Userrepository.GetAll(l => l.Username == txtUsername.Text && l.userPassword == txtPassword.Text).Select(u => u.UserID).SingleOrDefault();
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("اطلاعات وارد شده صحیح نمی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.Text = "تنظیمات کاربر";
                this.btnLogin.Text = "ویرایش کاربر";
                using (var uow = new UnitOfWorks())
                {
                    var id = Common.Common.UserID;
                    var data = uow.Userrepository.GetById(id);
                    this.txtUsername.Text = data.Username;
                    this.txtPassword.Text = data.userPassword;
                }

            }
        }
    }
}
