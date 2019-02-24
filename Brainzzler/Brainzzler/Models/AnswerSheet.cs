using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brainzzler.Models
{
    public class AnswerSheet
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int TestId { get; set; }
        public string Test_Name { get; set; }
        public int QuestionId { get; set; }
        public string Question_Text { get; set; }
        public long AnswerId { get; set; }
        public string Answer { get; set; }
        public short? Chosen { get; set; }
        public short? Correct { get; set; }
    }
}