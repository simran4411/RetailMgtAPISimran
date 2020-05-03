using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RetailMgt.Controllers
{
    public class APITestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}