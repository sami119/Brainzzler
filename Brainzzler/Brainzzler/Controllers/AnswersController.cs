using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Brainzzler.Models;

namespace Brainzzler.Controllers
{
    /// <summary>
    /// Този контролер управлява изпращането на отговорите от базата към jQuery-то, за използването им на страницата със тестове.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly Brainzzler_DBContext _context;

        /// <summary>
        /// Инициализира контекста
        /// </summary>
        /// <param name="context"></param>
        public AnswersController(Brainzzler_DBContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Връща първия отговор със дадено ид към jQuery който ги записва във answersheet
        /// </summary>
        /// <param name="id"></param>
        /// <returns>GET: api/Answers/{id}</returns>
        [HttpGet("{id}")]
        public ActionResult<Answer> GetAnswer(long id)
        {
            var answer = _context.Answers.Where(c => c.Id == id).FirstOrDefault();
            //var question = _context.Questions.Where(e => e.Answers.Contains(answer)).Single();

            if (answer == null)
            {
                return NotFound();
            }

            return answer;
        }      

        /// <summary>
        /// Проверява дали въпроса съществува във базата данни
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true or false</returns>
        private bool AnswerExists(long id)
        {
            return _context.Answers.Any(e => e.Id == id);
        }
    }
}
