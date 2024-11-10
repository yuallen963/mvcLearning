using Microsoft.AspNetCore.Mvc;
using mvcLearning.Models;

namespace mvcLearning.Controllers
{
    public class DemoController : Controller
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer() {Id = 1, Name="Sally", Amount=12345},
            new Customer() {Id = 2, Name="Billy", Amount=54632},
            new Customer() {Id = 3, Name="John", Amount=54651},
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Message"] = "Customer List";
            ViewData["CustomerCount"] = customers.Count();
            ViewData["CustomerList"] = customers;
            return View();
        }
    }
}
