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
    /// Този контролер оправлява вютата на Index и Privacy
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Врща вюто на началната страница
        /// </summary>
        /// <returns>Index.cshtml</returns>
        public IActionResult Index()
        {
            return View("Index");
        }

        /// <summary>
        /// Връща вюто на Privacy страницата 
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
