using BankLoan_Management133.Models;
using BankLoan_Management133.Repository;
using System.Collections.Generic;
using BankLogicProject.BusinessLogic;

namespace BankLoan_Management133.BusinessLogic
{
    public class CustomerBusinessLogic : IBusinessLogic
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerBusinessLogic(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public CustomerEntity GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public void SaveCustomer(CustomerEntity obj)
        {
            if (obj.CustomerId > 0)
            {
                _customerRepository.UpdateCustomer(obj);
            }
            else
            {
                _customerRepository.InsertCustomer(obj);
            }
        }

        public List<CustomerEntity> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }
        public void DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
        }
    }
}
