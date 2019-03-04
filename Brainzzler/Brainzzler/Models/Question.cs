using System;
using System.Collections.Generic;

namespace Brainzzler.Models
{
    public partial class Question
    {
        public long Id { get; set; }
        public string QuestionText { get; set; }
        public ICollection<Answer> Answers {get;set;}
        public double Score { get; set; }
        public Test Test { get; set; }
    }
}
