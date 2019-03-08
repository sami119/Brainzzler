﻿using System;
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
    public class QuestionsController : ControllerBase
    {
        private readonly Brainzzler_DBContext _context;

        public QuestionsController(Brainzzler_DBContext context)
        {
            _context = context;
        }

        

        // GET: api/Questions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetQuestion(long id)
        {
            var question = await _context.Questions.FindAsync(id);
            await _context.Entry(question).Collection(e => e.Answers).LoadAsync();


            if (question == null)
            {
                return NotFound();
            }

            return question;
        }

        

        private bool QuestionExists(long id)
        {
            return _context.Questions.Any(e => e.Id == id);
        }
    }
}