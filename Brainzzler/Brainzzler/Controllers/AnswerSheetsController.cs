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


        // GET: AnswerSheets/Details/5
        public async Task<IActionResult> AnswerSheet(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var answerSheet = await _context.AnswerSheet
            //    .FirstOrDefaultAsync(m => m.Id == id);
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

            Models.AnswerSheet as1;
            as1 = new AnswerSheet();
            as1.Id = 1;
            as1.UserId = "";
            as1.UserName = "UserName";
            as1.TestId = 1;
            as1.Test_Name = "Test_Name";
            as1.QuestionId = 1;
            as1.Question_Text = "Question_Text";
            as1.AnswerId = 1;
            as1.Answer = "";
            as1.Chosen = 1;
            as1.Correct = 1;
            return View(as1);

            if (answerSheet == null)
            {
                return NotFound();
            }

            return View(answerSheet);
        }

        // GET: AnswerSheets
        public async Task<IActionResult> Index()
        {
            return View(await _context.AnswerSheet.ToListAsync());
        }

        // GET: AnswerSheets/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerSheet = await _context.AnswerSheet
                .FirstOrDefaultAsync(m => m.Id == id);

            if (answerSheet == null)
            {
                return NotFound();
            }

            return View(answerSheet);
        }

        // GET: AnswerSheets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnswerSheets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,UserName,TestId,Test_Name,QuestionId,Question_Text,AnswerId,Answer,Chosen,Correct")] AnswerSheet answerSheet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(answerSheet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(answerSheet);
        }

        // GET: AnswerSheets/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerSheet = await _context.AnswerSheet.FindAsync(id);
            if (answerSheet == null)
            {
                return NotFound();
            }
            return View(answerSheet);
        }

        // POST: AnswerSheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,UserId,UserName,TestId,Test_Name,QuestionId,Question_Text,AnswerId,Answer,Chosen,Correct")] AnswerSheet answerSheet)
        {
            if (id != answerSheet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(answerSheet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnswerSheetExists(answerSheet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(answerSheet);
        }

        // GET: AnswerSheets/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerSheet = await _context.AnswerSheet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (answerSheet == null)
            {
                return NotFound();
            }

            return View(answerSheet);
        }

        // POST: AnswerSheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var answerSheet = await _context.AnswerSheet.FindAsync(id);
            _context.AnswerSheet.Remove(answerSheet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnswerSheetExists(long id)
        {
            return _context.AnswerSheet.Any(e => e.Id == id);
        }
    }
}
