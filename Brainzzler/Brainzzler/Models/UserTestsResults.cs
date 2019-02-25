using System;
using System.Collections.Generic;

namespace Brainzzler.Models
{
    public partial class UserTestsResults
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public int TestId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public short? Chosen { get; set; }
        public short? Correct { get; set; }
    }
}
