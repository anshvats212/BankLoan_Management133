using BankLoan_Management133.Models;
using System.Collections.Generic;

namespace BankLoan_Management133.Repository
{
    public interface ICustomerRepository
    {
        CustomerEntity GetCustomerById(int id);
        void InsertCustomer(CustomerEntity obj);
        void UpdateCustomer(CustomerEntity obj);
        List<CustomerEntity> GetAllCustomers();
        void DeleteCustomer(int id);
    }
}
