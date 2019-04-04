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
    /// Този контролер управлява изпращането на събраните от потребителя точки към страницата с игрите
    /// </summary>
    [Authorize]
    public class GamesController : Controller
    {
        private readonly Brainzzler_DBContext _context;
        private readonly IUserIdenityProvider _userIdenityProvider;

        /// <summary>
        /// Инициализира контекста, и IdenityProvider-a
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userIdenityProvider"></param>
        public GamesController(Brainzzler_DBContext context, IUserIdenityProvider userIdenityProvider)
        {
            _context = context;
            _userIdenityProvider = userIdenityProvider;
        }

        /// <summary>
        /// Вкарва точките събрани от потребителя във viewBag за да се използват в страницата с игрите
        /// </summary>
        /// <returns>/Games -> index.cshtml</returns>
        public IActionResult Index()
        {
            ViewBag.Points = Points();
            return View();
        }

        /// <summary>
        /// Сумира точките на потребителя.
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