using Accounting.DataLayer.Context;
using System.Collections.Generic;
using ViewModels.Customers;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customers> GettAll();
        List<CustomersViewModel> GetCustomerNames(string filter = "");
        IEnumerable<Customers> FilterdCustomer(string filterText);
        string GetCustomerNameById(int customerID);
        Customers GetById(int id);
        void InsertCustomers(Customers customer);
        void Update(Customers customer);
        void Delete(Customers customer);
        void Delete(int id);
    }
}
