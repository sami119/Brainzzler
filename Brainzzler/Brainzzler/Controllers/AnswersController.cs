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
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly Brainzzler_DBContext _context;

        public AnswersController(Brainzzler_DBContext context)
        {
            _context = context;
        }

        

        // GET: api/Answers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Answer>> GetAnswer(long id)
        {
            var answer = await _context.Answers.FindAsync(id);
            var question = _context.Questions.Where(e => e.Answers.Contains(answer)).Single();

            if (answer == null)
            {
                return NotFound();
            }

            return answer;
        }
        
        

        private bool AnswerExists(long id)
        {
            return _context.Answers.Any(e => e.Id == id);
        }
    }
}
