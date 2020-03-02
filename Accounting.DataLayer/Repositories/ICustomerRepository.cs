using Accounting.DataLayer.Context;
using System.Collections.Generic;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customers> GettAll();
        Customers GetById(int id);
        void InsertCustomers(Customers customer);
        void Update(Customers customer);
        void Delete(Customers customer);
        void Delete(int id);
        void Save();
    }
}
