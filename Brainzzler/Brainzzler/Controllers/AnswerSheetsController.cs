using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Brainzzler.Models;

namespace Brainzzler.Controllers
{
    public class AnswerSheetsController : Controller
    {
        private readonly Brainzzler_DBContext _context;

        public AnswerSheetsController(Brainzzler_DBContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[BindProperty]
        //public AnswerSheet this_AnswerSheet { get; set; }
        public async Task<IActionResult> AnswerSheet(long id, [Bind("Id,UserId,UserName,TestId,Test_Name,QuestionId,Question_Text,Question_Answers,AnswerId,Answer,Chosen,Correct")] AnswerSheet answerSheet)
        {
            if (id != answerSheet.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(answerSheet);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!AnswerSheetExists(answerSheet.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(AnswerSheet(id)));
            //}
            return View(answerSheet);
        }

        // GET: AnswerSheets/Details/5
        public async Task<IActionResult> AnswerSheet(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            string query = string.Format("select tq.id, '' UserId, '' UserName, TestId, t.Test Test_Name " +
                            " , tq.QuestionId, q.Question Question_Text " +
                            " , 0 AnswerId, '' Answer, 0 Chosen, 0 Correct " +
                            " from[dbo].[TestQuestions] tq " +
                            " join dbo.Test t on t.id = tq.TestId " +
                            " join Questions q on tq.QuestionId = q.Id " +
                            " where tq.Id = {0}", id);
            //TestId = 1 and QuestionId = 1
            //= @p0";
            var answerSheet = await _context.AnswerSheet.FromSql(query).FirstOrDefaultAsync<AnswerSheet>(m => m.Id == id);
            if (answerSheet == null)
            {
                return NotFound();
            }

            answerSheet.Question_Answers = await _context.Answers.Where(m => m.QuestionId.Equals(id)).ToListAsync();
            if (answerSheet.Question_Answers == null)
            {
                return NotFound();
            }

            return View(answerSheet);
        }

        private bool AnswerSheetExists(long id)
        {
            return _context.AnswerSheet.Any(e => e.Id == id);
        }
    }
}
