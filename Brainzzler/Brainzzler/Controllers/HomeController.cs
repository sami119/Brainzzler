using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Brainzzler.Models;

namespace Brainzzler.Controllers
{
    /// <summary>
    /// This controller is responsible for the Views of the Index and the Privacy
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Returns the View of the home page
        /// </summary>
        /// <returns>Index.cshtml</returns>
        public IActionResult Index()
        {
            return View("Index");
        }

        /// <summary>
        /// Returns the View of the Privacy page 
        /// </summary>
        /// <returns>Privacy.cshtml</returns>
        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
