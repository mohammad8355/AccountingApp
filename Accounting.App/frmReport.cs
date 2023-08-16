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
using Accounting.Utillity.Components;
using Accounting.App;
using Accounting.ViewModels;
using Accounting.DataLayer;
namespace Accounting.App
{
    public partial class frmReport : Form
    {
        public int TypeID = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {


                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    CustomerId = 0,
                    Fullname = "لطفایکی را انتخاب کنید"

                });
                list.AddRange(db.CustomerRepository.GetCustomerByName("",UserIDContainer.UserID));
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerId";

                //  dgvReport.DataSource = db.accountingRepository.Get(a => a.TypeID == TypeID && a.UserID == UserIDContainer.UserID);
                // dgvReport.AutoGenerateColumns = false;
                Filter();
            }




            if (TypeID == 1)
            {
                this.Text = "گزارش  دریافتی ها";
            }
            else
            {
                this.Text = "گزارش پرداختی ها";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }
        void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                List<DataLayer.Accounting> resualt = new List<DataLayer.Accounting>();
                DateTime? StartDate;
                DateTime? EndDate;
                if ((int)cbCustomer.SelectedValue != 0)
                {
                    int cusID = int.Parse(cbCustomer.SelectedValue.ToString());
                    resualt.AddRange(db.accountingRepository.Get(c => c.TypeID == TypeID && c.UserID == UserIDContainer.UserID && c.CustomerId == cusID));
                }
               
                else
                {
                    resualt.AddRange(db.accountingRepository.Get(c => c.TypeID == TypeID && c.UserID==UserIDContainer.UserID));
                }
                if (txtFromDate.Text != "    /  /")
                {
                    StartDate = Convert.ToDateTime(txtFromDate.Text);
                    StartDate = Dateconvertor.ToMiladi(StartDate.Value);
                    resualt = resualt.Where(c => c.DateTime >= StartDate.Value).ToList();
                }
                if (txtToDate.Text != "    /  /")
                {
                    EndDate = Convert.ToDateTime(txtToDate.Text);
                    EndDate = Dateconvertor.ToMiladi(EndDate.Value);
                    resualt = resualt.Where(c => c.DateTime <= EndDate.Value).ToList();
                }



                dgvReport.Rows.Clear();
                foreach (var customer in resualt)
                {

                    string customername = db.CustomerRepository.GetCustomerNameById(customer.CustomerId);
                    dgvReport.Rows.Add(customer.ID, customername, customer.Amount, customer.DateTime.ToShamsi(), customer.Description);
                };


            }
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                int id = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show("آیا از حذف این گزارش اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.accountingRepository.Delete(id);
                        db.save();
                        Filter();
                    }
                }
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    frmNewAccounting editReport = new frmNewAccounting();
                    editReport.TypeAccounting = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                    if (editReport.ShowDialog() == DialogResult.OK)
                    {
                        Filter();
                    }
                }


            }
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

