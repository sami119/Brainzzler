using System;
using System.Collections.Generic;

namespace Brainzzler.Models
{
    public partial class UserTestsResults
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public int TestId { get; set; }
        public int QuestionId { get; set; }
        public long AnswerId { get; set; }
        public short? Chosen { get; set; }
        public short? Correct { get; set; }
    }
}
