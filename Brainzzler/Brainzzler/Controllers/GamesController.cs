using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Brainzzler.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TwoZeroFourEight()
        {
            return View();
        }
    }
}