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
    public class TestQuestionsController : ControllerBase
    {
        private readonly Brainzzler_DBContext _context;

        public TestQuestionsController(Brainzzler_DBContext context)
        {
            _context = context;
        }

        // GET: api/TestQuestions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestQuestions>>> GetTestQuestions()
        {
            return await _context.TestQuestions.ToListAsync();
        }

        // GET: api/TestQuestions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestQuestions>> GetTestQuestions(long id)
        {
            var testQuestions = await _context.TestQuestions.FindAsync(id);

            if (testQuestions == null)
            {
                return NotFound();
            }

            return testQuestions;
        }

        // PUT: api/TestQuestions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestQuestions(long id, TestQuestions testQuestions)
        {
            if (id != testQuestions.Id)
            {
                return BadRequest();
            }

            _context.Entry(testQuestions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestQuestionsExists(id))
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

        // POST: api/TestQuestions
        [HttpPost]
        public async Task<ActionResult<TestQuestions>> PostTestQuestions(TestQuestions testQuestions)
        {
            _context.TestQuestions.Add(testQuestions);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestQuestions", new { id = testQuestions.Id }, testQuestions);
        }

        // DELETE: api/TestQuestions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TestQuestions>> DeleteTestQuestions(long id)
        {
            var testQuestions = await _context.TestQuestions.FindAsync(id);
            if (testQuestions == null)
            {
                return NotFound();
            }

            _context.TestQuestions.Remove(testQuestions);
            await _context.SaveChangesAsync();

            return testQuestions;
        }

        private bool TestQuestionsExists(long id)
        {
            return _context.TestQuestions.Any(e => e.Id == id);
        }
    }
}
