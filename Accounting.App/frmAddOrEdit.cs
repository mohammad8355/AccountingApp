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
using Accounting.DataLayer;
namespace Accounting.App
{
   
    public partial class frmAddOrEdit : Form
    {
        public int CustomerId = 0;
        UnitOfWork db = new UnitOfWork();
        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picBox.ImageLocation = openFile.FileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          
            string imagename = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(picBox.ImageLocation);
            string path = Application.StartupPath + "/Images/";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            picBox.Image.Save(path+imagename);
            if (BaseValidator.IsFormValid(this.components))
            {
                Customer customer = new Customer()
                {
                    FullName = txtName.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    CustomerImage = imagename,
                    UserID = UserIDContainer.UserID
                };
                if (CustomerId == 0)
                {
                   
                    db.CustomerRepository.InsertCustomer(customer);
                   
                }
                else if (CustomerId != 0)
                {
                    customer.CustomerId = CustomerId;
                    db.CustomerRepository.UpdateCustomer(customer);
                }
                db.save();
                DialogResult = DialogResult.OK;
          

            }
           
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if(CustomerId != 0)
            {
                
                btnSubmit.Text = "ویرایش";
                using(UnitOfWork db = new UnitOfWork())
                {
                    Customer customer = db.CustomerRepository.GetCustomerById(CustomerId);
                    txtName.Text = customer.FullName;
                    txtMobile.Text = customer.Mobile;
                    txtEmail.Text = customer.Email;
                    txtAddress.Text = customer.Address;
                    picBox.ImageLocation = Application.StartupPath + "/Images/"+ customer.CustomerImage;
                }
            }
            
        }
    }
}
