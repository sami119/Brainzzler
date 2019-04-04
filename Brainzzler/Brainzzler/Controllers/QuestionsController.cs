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
    /// Този контролер отговаря за въпросите
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
        /// взима от базата въпрос бо дадено ид, ако не намери връша грешка 404
        /// </summary>
        /// <param name="id"></param>
        /// <returns>дадения въпрос във json формат</returns>
        // GET: api/Questions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetQuestion(long id)
        {
            var question = await _context.Questions.FindAsync(id);
            await _context.Entry(question).Collection(e => e.Answers).LoadAsync();

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
