using System;
using System.Collections.Generic;
using System.Text;
using Brainzzler.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Brainzzler.Data
{
    public class BrainzzlerDbContext : IdentityDbContext
    {
        public BrainzzlerDbContext(DbContextOptions<BrainzzlerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<AnswerSheet> AnswerSheets { get; set; }
    }
}
