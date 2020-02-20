using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Customers = Repository.Customers;
            return View();
        }
    }
}