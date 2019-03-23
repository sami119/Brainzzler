using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainzzler.Models
{
    public partial class Answer
    {
        public long Id { get; set; }
        public string AnswerText { get; set; }
        public short Correct { get; set; }
        public string WrongText { get; set; }
        //public short Selected { get; set; } //Exists only in application. Calculated. 
    }
}
