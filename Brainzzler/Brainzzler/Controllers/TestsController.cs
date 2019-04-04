using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Brainzzler.Models;
using Microsoft.AspNetCore.Authorization;

namespace Brainzzler.Controllers
{
    /// <summary>
    /// this controller is responsible for the tests
    /// </summary>
    [Authorize]
    public class TestsController : Controller
    {
        private readonly Brainzzler_DBContext _context;

        /// <summary>
        /// Initializes the context
        /// </summary>
        /// <param name="context"></param>
        public TestsController(Brainzzler_DBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns(изкарва) all tests in the DB
        /// </summary>
        /// <returns>/Tests</returns>
        // GET: Tests
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tests.ToListAsync());
        }

        /// <summary>
        /// Returns the test on the given id
        /// Checks if the test exists,
        /// if it does, it takes it from the DB and loads all the questions and answers from the test
        /// </summary>
        /// <param name="id"></param>
        /// <returns>/Tests/Details/{id}</returns>
        public async Task<IActionResult> Details(long id)
        {
            if (TestExists(id))
            {
                var test = await _context.Tests
                .FirstOrDefaultAsync(m => m.Id == id);

                await _context.Entry(test).Collection(e => e.Questions).LoadAsync();
                foreach (var question in test.Questions)
                {
                    await _context.Entry(question).Collection(e => e.Answers).LoadAsync();
                }
                return View(test);
            }
            else
            {
                return NotFound();
            }
        }

        // GET: Tests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Test_Name")] Test test)
        {
            if (ModelState.IsValid)
            {
                _context.Add(test);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(test);
        }

        // GET: Tests/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test = await _context.Tests.FindAsync(id);
            if (test == null)
            {
                return NotFound();
            }
            return View(test);
        }

        // POST: Tests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Test_Name")] Test test)
        {
            if (id != test.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(test);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestExists(test.Id))
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
            return View(test);
        }

        // GET: Tests/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test = await _context.Tests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (test == null)
            {
                return NotFound();
            }

            return View(test);
        }

        // POST: Tests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var test = await _context.Tests.FindAsync(id);
            _context.Tests.Remove(test);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestExists(long id)
        {
            return _context.Tests.Any(e => e.Id == id);
        }
    }
}
