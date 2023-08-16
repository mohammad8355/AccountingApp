using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels;
namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        IEnumerable<Customer> GetCustomerByTd(string parameter);

        List<ListCustomerViewModel> GetCustomerByName(string filter = "",int userid = 0);
        Customer GetCustomerById(int customerId);
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int customerId);

        int GetCustomerIdByName(string name);

        string GetCustomerNameById(int Id);

        IEnumerable<Customer> GetCustomerByUserID(int userid);
    }
}
