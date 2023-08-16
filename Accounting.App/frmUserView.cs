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
using Accounting.DataLayer;
using System.ServiceModel.Channels;

namespace Accounting.App
{
    public partial class frmUserView : Form
    {
        public int userid = 0;
  
        public frmUserView()
        {
            InitializeComponent();
    
        }

        private void frmUserView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accounting_DBDataSet2.UserAccount' table. You can move, or remove it, as needed.
        
            using (UnitOfWork db = new UnitOfWork())
            {
                 
                txtUserN.Text = db.UserRepository.GetById(userid).Username;
                txtUserP.Text= db.UserRepository.GetById(userid).Password;
                this.userAccountTableAdapter.Fill(this.accounting_DBDataSet2.UserAccount);
                dgvUsers.AutoGenerateColumns = false;
                
            
             }
        }
     
        private void checkEditUsername_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditUsername.Checked)
            {
           
                btnEditUser.Visible = true;
            }
            else
            {
      
                btnEditUser.Visible = false;
            }
        }

        private void checkEditPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditPassword.Checked)
            {
         
                btnEditUser.Visible = true;
            }
            else
            {
      
                btnEditUser.Visible = false;
            }
        }

        private void HideUserName_CheckedChanged(object sender, EventArgs e)
        {
            if (HideUserName.Checked)
            {
                txtUserN.isPassword = true;
            }
            else
            {
                txtUserN.isPassword = false;
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txtUserP.isPassword = false;
            }
            else
            {
                txtUserP.isPassword = true;
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
            txtUserN.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            var user = db.UserRepository.GetById(int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString()));
            txtUserP.Text = user.Password;
            UserIDContainer.UserID = user.UserID;
            }
         
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                UserAccount updateUser = new UserAccount()
                {
                    Username = txtUserN.Text,
                    Password = txtUserP.Text
                };
                updateUser.UserID = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                db.UserRepository.Update(updateUser);
                db.save();
                this.userAccountTableAdapter.Fill(this.accounting_DBDataSet2.UserAccount);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("آیا از حذف این  حساب کاربری اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    db.UserRepository.Delete(UserIDContainer.UserID);
                    db.save();
                    this.userAccountTableAdapter.Fill(this.accounting_DBDataSet2.UserAccount);
                    dgvUsers.AutoGenerateColumns = false;

                }
            }
        }
    }
}
