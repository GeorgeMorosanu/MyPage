using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyPage.Controllers
{
    public class MyStoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}