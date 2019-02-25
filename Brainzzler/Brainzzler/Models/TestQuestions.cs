using System;
using System.Collections.Generic;

namespace Brainzzler.Models
{
    public partial class TestQuestions
    {
        public long Id { get; set; }
        public int TestId { get; set; }
        public int QuestionId { get; set; }
    }
}
