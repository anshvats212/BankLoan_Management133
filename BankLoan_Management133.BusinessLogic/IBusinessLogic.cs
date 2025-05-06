using BankLoan_Management133.Models;
using System.Collections.Generic;

namespace BankLoan_Management133.BusinessLogic
{
    public interface IBusinessLogic
    {
        CustomerEntity GetCustomerById(int id);
        void SaveCustomer(CustomerEntity obj);
        List<CustomerEntity> GetAllCustomers();
        void DeleteCustomer(int id);
    }
}

