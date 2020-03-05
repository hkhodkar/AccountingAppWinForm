using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities db;

        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public List<Customers> GettAll()
        {
            return db.Customers.ToList();
        }

        public Customers GetById(int id)
        {
            return db.Customers.Find(id);
        }

        public void InsertCustomers(Customers customer)
        {
            db.Customers.Add(customer);
        }


        public void Update(Customers customer)
        {
            db.Entry(customer).State = EntityState.Modified;
        }

        public void Delete(Customers customer)
        {
            db.Entry(customer).State = EntityState.Deleted;
        }

        public void Delete(int id)
        {
            var customer = GetById(id);
            Delete(customer);
        }

  
        public IEnumerable<Customers> FilterdCustomer(string filterText)
        {
           return db.Customers.Where(
                                c => c.FullName.Contains(filterText) || 
                                c.Mobile.Contains(filterText) || 
                                c.Email.Contains(filterText)).ToList();
        }
    }
}
