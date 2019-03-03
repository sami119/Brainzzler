select tq.id, '' UserId, '' UserName, TestId, t.Test Test_Name 
, tq.QuestionId, q.Question Question_Text 
, 0 AnswerId, '' Answer, 0 Chosen, 0 Correct 
from[dbo].[TestQuestions] tq 
join dbo.Test t on t.id = tq.TestId 
join Questions q on tq.QuestionId = q.Id 
where tq.Id = 5