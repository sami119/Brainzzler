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
    /// Този контролер управлява изпращането на въпросите от базата към jQuery-то, за използването им на страницата със тестове.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly Brainzzler_DBContext _context;

        /// <summary>
        /// Инициализира контекста
        /// </summary>
        /// <param name="context"></param>
        public QuestionsController(Brainzzler_DBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Връща първия въпрос със дадено ид към jQuery който ги връща към вюто
        /// </summary>
        /// <param name="id"></param>
        /// <returns>api/Questions/{id}</returns>
        [HttpGet("{id}")]
        public ActionResult<Question> GetQuestion(long id)
        {
            var question = _context.Questions.Where(c => c.Id == id).FirstOrDefault();
            //_context.Entry(question).Collection(e => e.Answers).Load();

            if (question == null)
            {
                return NotFound();
            }

            return question;
        }
        
        /// <summary>
        /// проверява дали въпроса съществува в базата дани
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true ако е открит, false ако не съществува</returns>
        private bool QuestionExists(long id)
        {
            return _context.Questions.Any(e => e.Id == id);
        }
    }
}
