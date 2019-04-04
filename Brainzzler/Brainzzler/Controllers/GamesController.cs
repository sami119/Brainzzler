using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Brainzzler.Models;
using Brainzzler.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Brainzzler.Controllers
{
    /// <summary>
    /// This controller is responsible for sending of the gained by the user points to the page with the games
    /// </summary>
    [Authorize]
    public class GamesController : Controller
    {
        private readonly Brainzzler_DBContext _context;
        private readonly IUserIdenityProvider _userIdenityProvider;

        /// <summary>
        /// Intializes the context and the IdenityProvider
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userIdenityProvider"></param>
        public GamesController(Brainzzler_DBContext context, IUserIdenityProvider userIdenityProvider)
        {
            _context = context;
            _userIdenityProvider = userIdenityProvider;
        }

        /// <summary>
        /// Puts the points gained by the user in the viewBag for being used in the page with the games
        /// </summary>
        /// <returns>/Games -> index.cshtml</returns>
        public IActionResult Index()
        {
            ViewBag.Points = Points();
            return View("Index");
        }

        /// <summary>
        /// Sums the points of the user
        /// </summary>
        /// <returns>points</returns>
        public double Points()
        {
            double points = 0;
            var userId = _userIdenityProvider.GetCurrentUserId();

            //calculate total points
            points = _context
                .AnswerSheet.Where(answerSheet => answerSheet.UserId == userId)
                .Sum(answerSheet => answerSheet.Score.CurrentScore);
            return points;
        }
    }
}