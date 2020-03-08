using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ViewModels.Customers;

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

        public List<CustomersViewModel> GetCustomerNames(string filter = "")
        {
            if (filter == "")
            {
                return db.Customers.Select(c => new CustomersViewModel()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName
                }).ToList();
            }
            return db.Customers.Where(c => c.FullName.Contains(filter))
                               .Select(c => new CustomersViewModel()
                               {
                                   FullName = c.FullName,
                                   CustomerID = c.CustomerID
                               }).ToList();
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

        public string GetCustomerNameById(int customerID)
        {
            return db.Customers.Where(c => c.CustomerID == customerID).Select(c => c.FullName).SingleOrDefault();
        }
    }
}
