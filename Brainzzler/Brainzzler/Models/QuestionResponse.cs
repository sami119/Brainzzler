using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brainzzler.Models
{
    public class QuestionResponse
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public List<Answer> SelectedAnswers { get; set; }
        public String TextAnswer { get; set; }//Possible freetext answers, not used for now
    }
}
