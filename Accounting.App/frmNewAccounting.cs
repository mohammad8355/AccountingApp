using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Contex;
using ValidationComponents;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Repositories;
using System.Globalization;
namespace Accounting.App
{
    public partial class frmNewAccounting : Form
    {
        public int TypeAccounting = 0;
        public frmNewAccounting()
        {
            InitializeComponent();
        }

        private void frmNewAccounting_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomer.AutoGenerateColumns = false;
                dgvCustomer.DataSource = db.CustomerRepository.GetCustomerByName("",UserIDContainer.UserID);

            } 
            if(TypeAccounting != 0)
            {
               using(UnitOfWork db = new UnitOfWork())
                {
                 var account =  db.accountingRepository.GetById(TypeAccounting);
                    txtcustomer.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerId);
                    amount.Value = account.Amount;
                    txtDescribtion.Text = account.Description;
                    if(account.TypeID == 1)
                    {
                        rbRecive.Checked = true;
                    }
                    else
                    {
                        rbPay.Checked = true;
                    }
                    this.Text = "ویرایش گزارش";
                    btnsave.Text = "ویرایش";
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomer.AutoGenerateColumns = false;
                dgvCustomer.DataSource = db.CustomerRepository.GetCustomerByName(txtFilter.Text,UserIDContainer.UserID);
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustomer.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                   if (BaseValidator.IsFormValid(this.components))
            {
                    if (rbPay.Checked || rbRecive.Checked)
                    {
                        DataLayer.Accounting accounting = new DataLayer.Accounting()
                        {
                            Amount = int.Parse(amount.Value.ToString()),
                            Description = txtDescribtion.Text,
                            CustomerId = db.CustomerRepository.GetCustomerIdByName(txtcustomer.Text),
                            TypeID = (rbRecive.Checked) ? 1 : 2,
                            DateTime = DateTime.Now,
                           UserID = UserIDContainer.UserID
                        };
                        if(TypeAccounting == 0)
                        {
                        db.accountingRepository.Insert(accounting);
                        }
                        else
                        {
                            accounting.ID = TypeAccounting;
                            db.accountingRepository.Update(accounting);
                        }
                        db.save();
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("لطفا حالت تراکنش را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            }
        }
    }

