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
        public Test Test { get; set; }
        public List<QuestionResponse> QuestionResponses { get; set; }
        public Score Score {get;set;}
    }
}