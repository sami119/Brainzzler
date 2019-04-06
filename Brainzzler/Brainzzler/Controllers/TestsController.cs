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
        /// Returns all tests in the DB
        /// </summary>
        /// <returns>GET: Tests</returns>
        public IActionResult Index()
        {
            return View(_context.Tests.ToList());
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

        /// <summary>
        /// Returns view
        /// </summary>
        /// <returns>GET: Tests/Create</returns>
        public IActionResult Create()
        {
            return View("Create");
        }

        /// <summary>
        /// Creates test and saves changes
        /// </summary>
        /// <param name="test"></param>
        /// <returns>POST: Tests/Create</returns>
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

        /// <summary>
        /// finds test by ID and returns it for future use
        /// </summary>
        /// <param name="id"></param>
        /// <returns>GET: Tests/Edit/5</returns>
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

        /// <summary>
        /// Updates test and saves it to DB;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="test"></param>
        /// <returns>POST: Tests/Edit/5</returns>
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

        /// <summary>
        /// finds test in DB and returns it to the view for DeleteConfirmed
        /// </summary>
        /// <param name="id"></param>
        /// <returns>GET: Tests/Delete/5</returns>
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

        /// <summary>
        /// Deletes test from DB and saves changes
        /// </summary>
        /// <param name="id"></param>
        /// <returns>POST: Tests/Delete/5</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var test = await _context.Tests.FindAsync(id);
            _context.Tests.Remove(test);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Checks if the test exists in the DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true or false</returns>
        private bool TestExists(long id)
        {
            return _context.Tests.Any(e => e.Id == id);
        }
    }
}
