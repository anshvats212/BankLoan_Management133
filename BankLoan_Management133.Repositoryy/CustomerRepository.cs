using BankLoan_Management133.Models;
using System.Collections.Generic;
using System.Linq;

namespace BankLoan_Management133.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DatabaseContext _db;

        public CustomerRepository(DatabaseContext context)
        {
            _db = context;
        }

        public CustomerEntity GetCustomerById(int id)
        {
            return _db.customerEntities.FirstOrDefault(a => a.CustomerId == id);
        }

        public void InsertCustomer(CustomerEntity obj)
        {
            _db.customerEntities.Add(obj);
            _db.SaveChanges();
        }

        public void UpdateCustomer(CustomerEntity obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }

        public List<CustomerEntity> GetAllCustomers()
        {
            return _db.customerEntities.ToList();
        }
        public void DeleteCustomer(int id)
        {
            var data = _db.customerEntities.Find(id);
            _db.customerEntities.Remove(data);
            _db.SaveChanges();
        }
    }
}
