--select tq.id, '' UserId, '' UserName, TestId, t.Test Test_Name 
--, tq.QuestionId, q.Question Question_Text 
--, 0 AnswerId, '' Answer, 0 Chosen, 0 Correct 
--from[dbo].[TestQuestions] tq 
--join dbo.Test t on t.id = tq.TestId 
--join Questions q on tq.QuestionId = q.Id 
--where tq.Id = 5

--delete from Test;
--delete from Questions;
--delete from Answers;
--delete from TestQuestions;


declare @Test_id int;
declare @Question_id int;

INSERT INTO Test (Test) VALUES(N'Входно ниво 5 клас.');
set @Test_id = (select SCOPE_IDENTITY()); 

--INSERT INTO Questions(Question) VALUES(N''); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
--INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);
--INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);
--INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);
--INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);

INSERT INTO Questions(Question) VALUES(N'Компютърната система представлява'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Софтуер и данни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'хардуер и софтуер', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'хардуер и данни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'софтуер хардуер и данни', 0);

INSERT INTO Questions(Question) VALUES(N'Към хардуер не се отнасят'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Комютърна програма', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'дънна платка', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'централен процесор', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'комютърна памет', 0);
