using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer.Contex;
using Accounting.DataLayer;
namespace Accounting.App
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using(UnitOfWork db = new UnitOfWork())
                {
                    if(db.UserRepository.Get(c => c.Username == txtUserName.Text).Any())
                    {
                        MessageBox.Show("نام کاربری قبلا ثبت شده است");
                        this.DialogResult = DialogResult.OK;
                    }
                    if(txtPassword1.Text == txtPassword2.Text)
                    {
                        UserAccount newUser = new UserAccount()
                        {
                            Username = txtUserName.Text,
                            Password = txtPassword2.Text
                        };
                        db.UserRepository.Insert(newUser);
                        db.save();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("رمز عبور یکسان نمی باشد ");

                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword1.UseSystemPasswordChar = false;
                txtPassword2.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword1.UseSystemPasswordChar = true;
                txtPassword2.UseSystemPasswordChar = true;
            }
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_MouseHover(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.Crimson;
            btnSignIn.ForeColor = Color.White;
        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.White;
            btnSignIn.ForeColor = Color.Crimson;
        }

     
    }
}
