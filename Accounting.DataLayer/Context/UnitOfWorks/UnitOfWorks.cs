using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using System;

namespace Accounting.DataLayer.Context.UnitOfWorks
{
    public class UnitOfWorks : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();
        private ICustomerRepository _customerRepository;
        private GenericRepository<Accounting> _accountingRepo;

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }

        public GenericRepository<Accounting> AccountingRepo
        {
            get
            {
                if (_accountingRepo == null)
                {
                    _accountingRepo = new GenericRepository<Accounting>(db);
                }
                return _accountingRepo;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }


        public void Dispose()
        {
            db.Dispose();
        }
    }
}
