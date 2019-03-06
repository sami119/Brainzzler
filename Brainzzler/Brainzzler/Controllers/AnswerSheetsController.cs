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

        public AnswerSheetsController(Brainzzler_DBContext context)
        {
            _context = context;
        }

       
        // PUT: api/AnswerSheets/5
        [HttpPut("{id}")]
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
        public async Task<string> PostAnswerSheet()
        {
           // await _context.SaveChangesAsync();
            //todo get and save other stuff here
            AnswerSheet resultAnswerSheet = new AnswerSheet();
            resultAnswerSheet.QuestionResponses = new List<QuestionResponse>();
            resultAnswerSheet.Test = _context.Tests.Find(long.Parse(Request.Form["testId"]));
            //проверяваме дали потребителя е логнат и какво е ид-то му
            var claimsIdentity = User.Identity as ClaimsIdentity;
            if (claimsIdentity != null)
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

            var questionResponses = Request.Form["QuestionResponses"];
            foreach (var item in questionResponses)
            {
                Answer answer = _context.Answers.Find(int.Parse(item));
                Question question = _context.Questions.Where(q => q.Answers.Contains(answer)).Single();
                QuestionResponse questionResponse = new QuestionResponse();
                questionResponse.Question = question;
                questionResponse.SelectedAnswers = new List<Answer>() { answer };
                questionResponse.TextAnswer = "";
                resultAnswerSheet.QuestionResponses.Add(questionResponse);
            }

            Score score = new Score();
            score.CurrentScore = double.Parse(Request.Form["Score"]);
            score.MaxScore = 0;
            resultAnswerSheet.Score = score;
            var answerSheet = _context.AnswerSheet.Add(resultAnswerSheet);
            await _context.SaveChangesAsync();

            return "{\"status\": \"ok\"}";
        }
        
        private bool AnswerSheetExists(long id)
        {
            return _context.AnswerSheet.Any(e => e.Id == id);
        }
    }
}
