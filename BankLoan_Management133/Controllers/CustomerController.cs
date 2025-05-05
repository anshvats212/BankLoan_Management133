using Microsoft.AspNetCore.Mvc;
using BankLoan_Management133.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankLoan_Management133.Controllers
{
    public class CustomerController : Controller
    {
        public readonly DatabaseContext _db;
        public CustomerController(DatabaseContext context)
        {
            _db = context;
        }
        public IActionResult Index(int id=0)
        {
            CustomerEntity obj = new CustomerEntity();
            ViewBag.st = "Submit";
            if (id > 0)
            {
                var data = (from a in _db.customerEntities where a.CustomerId == id select a).ToList();
                obj.CustomerId = data[0].CustomerId;
                obj.Name = data[0].Name;
                obj.Email = data[0].Email;
                obj.Phone = data[0].Phone;
                obj.Address = data[0].Address;
                obj.KycStatus = data[0].KycStatus;
                ViewBag.st = "Update";
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Index(CustomerEntity obj)
        {
            if (obj.CustomerId > 0)
            {
       _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            }
            else
            {
                _db.customerEntities.Add(obj);
            }
            _db.SaveChanges();
            return RedirectToAction("Show");
        }

        public IActionResult Show()
        {
            var data = _db.customerEntities.ToList();
            return View(data);
        }
 public IActionResult Delete(int id=0)
        {
            var data = _db.customerEntities.Find(id);
            _db.customerEntities.Remove(data);
            _db.SaveChanges();
            return RedirectToAction("Show");
        }

    }
}
