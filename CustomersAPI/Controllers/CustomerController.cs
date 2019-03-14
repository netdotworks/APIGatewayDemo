using CustomersAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomersAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CustomerController : Controller
    {
        private readonly IList<Customer> _customers;

        public CustomerController()
        {
            _customers = new List<Customer>()
            {
                new Customer {Code = "00001", Id = 1, Name = "Customer1"}
            };
        }

        public IActionResult GetCustomers()
        {
            return Json(_customers);
        }
    }
}