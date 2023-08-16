using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.Contex;
using Accounting.DataLayer.Repositories;
using Accounting.ViewModels;
namespace Accounting.DataLayer.Services
{
    public class UserRepository : GenericRepository<UserAccount>
    {
      

        Accounting_DBEntities db;
        public UserRepository(Accounting_DBEntities context) : base(context)
        {
            db = context;
        }

        public List<ListUsersViewModel> GetUserList()
        {
            return db.UserAccounts.Select(u => new ListUsersViewModel()
            {
                UserId = u.UserID,
                UserName = u.Username
            }).ToList();
        }
       public int GetUserAccountByName(string Username)
        {
       
            return db.UserAccounts.First(u => u.Username == Username).UserID;
        }

        }

    }

