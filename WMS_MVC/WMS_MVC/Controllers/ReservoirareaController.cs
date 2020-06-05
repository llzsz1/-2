using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMS_MVC.Controllers
{
    public class ReservoirareaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}