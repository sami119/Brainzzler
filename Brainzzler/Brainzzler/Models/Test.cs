using System;
using System.Collections.Generic;

namespace Brainzzler.Models
{
    public partial class Test
    {
        public long Id { get; set; }
        public string Test_Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; } //foreign key!
    }
}
