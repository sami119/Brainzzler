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


select tq.id, null UserId, '' UserName, TestId, t.Test TestName
, tq.QuestionId, q.Question Question_Text
from [dbo].[TestQuestions] tq
join dbo.Test t on t.id = tq.TestId
join Questions q on tq.QuestionId = q.Id
where TestId = 1 and QuestionId = 1

