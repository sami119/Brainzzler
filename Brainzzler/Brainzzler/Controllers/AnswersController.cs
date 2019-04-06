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
    /// The controller is responsible for sending the answers from the DB to the jQuery for their using on the page with the tests.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly Brainzzler_DBContext _context;

        /// <summary>
        /// Intializes the context
        /// </summary>
        /// <param name="context"></param>
        public AnswersController(Brainzzler_DBContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Returns the first answer with the given id to jQuery, whitch saves them in the answersheet
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
        /// Checks out if the question exists in the DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true or false</returns>
        private bool AnswerExists(long id)
        {
            return _context.Answers.Any(e => e.Id == id);
        }
    }
}
