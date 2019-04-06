using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Brainzzler.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Brainzzler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerSheetsController : ControllerBase
    {
        private readonly Brainzzler_DBContext _context;

        /// <summary>
        /// Initializes the context
        /// </summary>
        /// <param name="context"></param>
        public AnswerSheetsController(Brainzzler_DBContext context)
        {
            _context = context;
        }

       
        // PUT: api/AnswerSheets/5
        [HttpPut("{id}")]
        /// <summary>
        /// Finds the answersheet by id
        /// </summary>
        /// <param name="context"></param>
        public async Task<IActionResult> PutAnswerSheet(long id, AnswerSheet answerSheet)
        {
            if (id != answerSheet.Id)
            {
                return BadRequest();
            }

            _context.Entry(answerSheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnswerSheetExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AnswerSheets
        [HttpPost]

        /// <summary>
        ///This controller creates answersheet and insert the data into the DB. After that it saves the changes
        /// </summary>
        public async Task<string> PostAnswerSheet()
        {
            // await _context.SaveChangesAsync();
            //todo get and save other stuff here
            AnswerSheet resultAnswerSheet = new AnswerSheet
            {
                QuestionResponses = new List<QuestionResponse>(),
                Test = _context.Tests.Find(long.Parse(Request.Form["testId"]))
            };

            /// <summary>
            ///Checks if the user is loged in and what is his id
            /// </summary>
            if (User.Identity is ClaimsIdentity claimsIdentity)
            {
                var userIdClaim = claimsIdentity.Claims
                    .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

                if (userIdClaim != null)
                {
                    //има такъв потребител
                    var userIdValue = userIdClaim.Value;
                    resultAnswerSheet.UserId = userIdValue;
                    resultAnswerSheet.UserName = User.Identity.Name;
                }
                else
                {
                    resultAnswerSheet.UserId = "0";
                    resultAnswerSheet.UserName = "Guest";
                }
            }
            else
            {
                resultAnswerSheet.UserId = "0";
                resultAnswerSheet.UserName = "Guest";
            }

            /// <summary>
            /// Puts all the answers given during the test into answersheet.question responses
            /// </summary>
            var questionResponses = Request.Form["QuestionResponses"];
            foreach (var item in questionResponses)
            {
                Answer answer = _context.Answers.Find(int.Parse(item));
                Question question = _context.Questions.Where(q => q.Answers.Contains(answer)).Single();
                QuestionResponse questionResponse = new QuestionResponse
                {
                    Question = question,
                    SelectedAnswers = new List<Answer>() { answer },
                    TextAnswer = ""
                };
                resultAnswerSheet.QuestionResponses.Add(questionResponse);
            }

            Score score = new Score
            {
                CurrentScore = double.Parse(Request.Form["Score"]),
                MaxScore = 0
            };
            resultAnswerSheet.Score = score;
            var answerSheet = _context.AnswerSheet.Add(resultAnswerSheet);
            await _context.SaveChangesAsync();

            return "{\"status\": \"ok\"}";
        }

        /// <summary>
        ///Checks if the answer exists
        /// </summary>
        private bool AnswerSheetExists(long id)
        {
            return _context.AnswerSheet.Any(e => e.Id == id);
        }
    }
}
