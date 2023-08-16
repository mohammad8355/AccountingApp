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
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer;
using Accounting.ViewModels;
namespace Accounting.App
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
                  
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
             
                DgCustomers.AutoGenerateColumns = false;
                DgCustomers.DataSource = db.CustomerRepository.GetCustomerByUserID(UserIDContainer.UserID);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = " ";
            BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
           using(UnitOfWork db = new UnitOfWork())
            {
                DgCustomers.DataSource = db.CustomerRepository.GetCustomerByTd(txtFilter.Text);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if(DgCustomers.CurrentRow != null)
            {
               using(UnitOfWork db = new UnitOfWork())
            {
                    string name = DgCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($" اطمینان دارید؟{name} آیا از حذف شخص","هشدار",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                    {
                    int CustomerID = int.Parse(DgCustomers.CurrentRow.Cells[0].Value.ToString());
                    db.CustomerRepository.DeleteCustomer(CustomerID);
                    db.save();
                    BindGrid();
                    }
            }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را انتخاب کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEdit addcustomer = new frmAddOrEdit();
            addcustomer.ShowDialog();
            if(addcustomer.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if(DgCustomers.CurrentRow != null)
            {
                frmAddOrEdit editcustomer = new frmAddOrEdit();
                editcustomer.Text = "ویرایش شخص";
                int customerid = int.Parse(DgCustomers.CurrentRow.Cells[0].Value.ToString());
                editcustomer.CustomerId = customerid;

                if (editcustomer.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
              
            }
        }

     
    }
}
