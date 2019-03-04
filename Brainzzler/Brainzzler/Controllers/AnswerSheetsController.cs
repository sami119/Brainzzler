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
        public async Task<ActionResult<AnswerSheet>> PostAnswerSheet(AnswerSheet answerSheet)
        {
            _context.AnswerSheet.Add(answerSheet);
            await _context.SaveChangesAsync();
            //todo get and save other stuff here
            return CreatedAtAction("GetAnswerSheet", new { id = answerSheet.Id }, answerSheet);
        }
        
        private bool AnswerSheetExists(long id)
        {
            return _context.AnswerSheet.Any(e => e.Id == id);
        }
    }
}
