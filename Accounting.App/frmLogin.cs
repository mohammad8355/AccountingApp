using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Contex;
using ValidationComponents;
using Accounting.DataLayer.Services;
namespace Accounting.App
{

    public partial class frmLogin : Form
    {
       
  
     
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
              using(UnitOfWork db = new UnitOfWork())
              {
               if(db.UserRepository.Get(u => u.Username==txtUsername.Text && u.Password == txtPassword.Text).Any())
                    {
                       int userId  = db.UserRepository.GetUserAccountByName(txtUsername.Text);
                        UserIDContainer.UserID = userId;


             //             Form1 mainform = new Form1();
             //     mainformUserID = userId;*/


                        DialogResult = DialogResult.OK; 
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }
              }
            }
          
        }
     
        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
               txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignIn signin = new frmSignIn();
            signin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
