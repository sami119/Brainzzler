using System;
using System.Collections.Generic;

namespace Brainzzler.Models
{
    public partial class Answers
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public string Answer { get; set; }
        public short Correct { get; set; }
    }
}
