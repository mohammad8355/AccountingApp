﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
namespace Accounting.DataLayer.Contex
{
   public  class UnitOfWork : IDisposable

    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepository _customerRepository;
       public ICustomerRepository CustomerRepository
    {
        get
        {
            if(_customerRepository == null)
            {
                _customerRepository = new CustomerRepository(db); 
            }
            return _customerRepository;
        }

    }

        private GenericRepository<Accounting> _accountingRepository;

        public GenericRepository<Accounting> accountingRepository
        {
            get
            {
                if(_accountingRepository == null)
                {
                    _accountingRepository = new GenericRepository<Accounting>(db);
                }
                return _accountingRepository;
            }
        }

        private UserRepository _userrepository;

      public UserRepository UserRepository
        {
            get
            {
                 if(_userrepository == null)
                {
                    _userrepository = new UserRepository(db);
                }
                return _userrepository;
            }
        }
       

        public void save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
