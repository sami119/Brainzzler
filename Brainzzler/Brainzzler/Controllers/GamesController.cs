using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Brainzzler.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Brainzzler.Controllers
{
    [Authorize]
    public class GamesController : Controller
    {
        private readonly Brainzzler_DBContext _context;

        public GamesController(Brainzzler_DBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Points = Points();
            return View();
        }

        public double Points()
        {
            double points = 0;
            if (User.Identity is ClaimsIdentity claimsIdentity)
            {
                var userIdClaim = claimsIdentity.Claims
                    .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

                if (userIdClaim != null)
                {
                    //има такъв потребител
                    var userIdValue = userIdClaim.Value;

                    //calculate total points
                    points = _context.AnswerSheet
                        .Where(answerSheet => answerSheet.UserId == userIdValue).
                        Sum(answerSheet => answerSheet.Score.CurrentScore);
                }
            }
            return points;
        }
    }
}