using Accounting.DataLayer.Repositories;
using Accounting.ViewModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Accounting.DataLayer;
using Accounting.DataLayer.Contex;
namespace Accounting.DataLayer.Services
{
    class CustomerRepository : ICustomerRepository
    {
        Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities contex)
        {
            db = contex;
        }
        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customer GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public List<ListCustomerViewModel> GetCustomerByName(string filter = "" ,int userid = 0)
        {
            if (filter == null)
            {
                return db.Customers.Where(c => c.UserID == userid).Select(c => new ListCustomerViewModel()
                {
                    Fullname = c.FullName,
                  CustomerId = c.CustomerId,
               
                }
                ).ToList();
            }
            return db.Customers.Where(c => c.FullName.Contains(filter) && c.UserID == userid).Select(c => new ListCustomerViewModel()
            {
                Fullname = c.FullName,
                CustomerId = c.CustomerId,
       
            }).ToList();
        }

        public IEnumerable<Customer> GetCustomerByTd(string parameter)
        {
            return db.Customers.Where(c => c.FullName.Contains(parameter) || c.Mobile.Contains(parameter) || c.Email.Contains(parameter)).ToList();
        }

        public int GetCustomerIdByName(string name)
        {
            return  db.Customers.First(c => c.FullName == name).CustomerId;
        }

        public string GetCustomerNameById(int Id)
        {
            return db.Customers.Find(Id).FullName;
        }

        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IEnumerable<Customer> GetCustomerByUserID (int userid)
        {
            return db.Customers.Where(c => c.UserID == userid).ToList();
        }


        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
