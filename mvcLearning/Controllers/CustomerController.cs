﻿using Microsoft.AspNetCore.Mvc;
using mvcLearning.Models;

namespace mvcLearning.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customerList = new List<Customer>()
        {
            new Customer() {Id = 1, Name="Sally", Amount=12345},
            new Customer() {Id = 2, Name="Billy", Amount=54632},
            new Customer() {Id = 3, Name="John", Amount=54651},
        };

        public IActionResult Index()
        {
            ViewBag.Message = "Customer List";
            ViewBag.CustomerCount = customerList.Count;
            ViewBag.customers = customerList;
            return View();
        }

        public IActionResult Details()
        {

            return View();
        }

        //[Route("~/")]
        [Route("/sample/message")]
        public IActionResult Message()
        {
            return View();
        }
    }
}
