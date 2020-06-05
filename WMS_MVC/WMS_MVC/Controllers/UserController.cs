using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMS_MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserShow()
        {
            return View();
        }
        public IActionResult DeptShow()
        {
            return View();
        }
    }
}