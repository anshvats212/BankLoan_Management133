using Microsoft.AspNetCore.Mvc;
using BankLoan_Management133.Models;
using BankLoan_Management133.BusinessLogic;


namespace BankLoan_Management133.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IBusinessLogic _businessLogic;

        public CustomerController(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public IActionResult Index(int id = 0)
        {
            CustomerEntity obj = new CustomerEntity();
            ViewBag.st = "Submit";
            if (id > 0)
            {
                obj = _businessLogic.GetCustomerById(id);
                ViewBag.st = "Update";
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Index(CustomerEntity obj)
        {
            _businessLogic.SaveCustomer(obj);
            return RedirectToAction("Show");
        }

        public IActionResult Show()
        {
            var data = _businessLogic.GetAllCustomers();
            return View(data);
        }
        public IActionResult Delete(int id = 0)
        {
            _businessLogic.DeleteCustomer(id);
            return RedirectToAction("Show");
        }
    }
}