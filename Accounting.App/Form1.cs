using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Utillity.Components;
using Accounting.DataLayer.Contex;
namespace Accounting.App
{
    public partial class Form1 : Form
    {

        public static int UserID;
       
    
     
        public Form1()
        {
            InitializeComponent();
        
   
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.ShowDialog();
        }

        private void btnNewAccounting_Click(object sender, EventArgs e)
        {
            frmNewAccounting newAccounting = new frmNewAccounting();
            newAccounting.ShowDialog();
        }

        private void btnReceiveReport_Click(object sender, EventArgs e)
        {
            frmReport ReceiveReport = new frmReport();
            ReceiveReport.TypeID = 1;
            ReceiveReport.ShowDialog();
        }

        private void btnPaymentReport_Click(object sender, EventArgs e)
        {
            frmReport ReceiveReport = new frmReport();
            ReceiveReport.TypeID = 2;
            ReceiveReport.ShowDialog();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           lblTime.Text =  DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            if (login.ShowDialog()== DialogResult.OK)
            {
                this.Visible = true;
               lblDate.Text = DateTime.Now.ToShamsi();
            }
            else
            {
                Application.Exit();
            }
          
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
     
            frmUserView userView = new frmUserView();
                userView.userid = UserIDContainer.UserID;
            userView.ShowDialog();
            }
         
           
        }
    }
}
