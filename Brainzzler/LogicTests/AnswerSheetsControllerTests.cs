using Brainzzler.Controllers;
using Brainzzler.Models;
using NUnit.Framework;
using Moq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor;
using Microsoft.AspNetCore.Mvc;

namespace Tests
{
    public class AnswerSheetsControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AnswerSheetsControllerReturnsNoContentAsync()
        {
            //initialize
            Answer answer = new Answer { Id = 1, AnswerText = "Отговор 1", Correct = 1, WrongText = "" };
            Answer answer2 = new Answer { Id = 2, AnswerText = "Отговор 2", Correct = 0, WrongText = "" };
            Answer answer3 = new Answer { Id = 3, AnswerText = "Отговор 3", Correct = 0, WrongText = "" };
            List<Answer> answers = new List<Answer> { answer, answer2, answer3 };
            Question question = new Question { Answers = answers, Id = 1, QuestionText = "Въпрос", Score = 2, WrongText = "" };
            List<Question> questions = new List<Question> { question };
            var questionResponse = new QuestionResponse { Id = 1, Question = question, SelectedAnswers = new List<Answer> { answer }, TextAnswer = "" };
            List<QuestionResponse> questionResponses = new List<QuestionResponse> { questionResponse };
            Score score = new Score { Id = 1, CurrentScore = 2, MaxScore = 2, Note = "" };
            Test test = new Test { Id = 1, Test_Name = "Начално ниво", Questions = questions };

            Answer answer4 = new Answer { Id = 4, AnswerText = "Отговор 4", Correct = 0, WrongText = "" };
            Answer answer5 = new Answer { Id = 5, AnswerText = "Отговор 5", Correct = 1, WrongText = "" };
            Answer answer6 = new Answer { Id = 6, AnswerText = "Отговор 6", Correct = 0, WrongText = "" };
            List<Answer> answers2 = new List<Answer> { answer4, answer5, answer6 };
            Question question2 = new Question { Answers = answers2, Id = 2, QuestionText = "Въпрос", Score = 2, WrongText = "" };
            List<Question> questions2 = new List<Question> { question2 };
            var questionResponse2 = new QuestionResponse { Id = 2, Question = question2, SelectedAnswers = new List<Answer> { answer5 }, TextAnswer = "" };
            List<QuestionResponse> questionResponses2 = new List<QuestionResponse> { questionResponse2 };
            Score score2 = new Score { Id = 2, CurrentScore = 2, MaxScore = 2, Note = "" };
            Test test2 = new Test { Id = 2, Test_Name = "Средно ниво", Questions = questions2 };

            var answerSheet = new AnswerSheet { Id = 0, QuestionResponses = questionResponses, Score = score, Test = test, UserId = "1", UserName = "TestUser" };
            var answerSheet2 = new AnswerSheet { Id = 0, QuestionResponses = questionResponses2, Score = score2, Test = test2, UserId = "1", UserName = "TestUser" };

            var data = new List<AnswerSheet> { answerSheet }.AsQueryable();

            var mockSet = new Mock<DbSet<AnswerSheet>>();
            mockSet.As<IQueryable<AnswerSheet>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<AnswerSheet>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<AnswerSheet>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<AnswerSheet>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<Brainzzler_DBContext>();
            mockContext.Setup(set => set.AnswerSheet).Returns(mockSet.Object);
            
            //act
            var controller = new AnswerSheetsController(mockContext.Object);
            controller.PutAnswerSheet(0, answerSheet2);
            mockContext.Object.SaveChanges();

            //assert
            Assert.AreEqual(answerSheet2, mockContext.Object.AnswerSheet.Find(0));

        }

        [Test]
        public  void AnswerSheetsControllerPostsOk()
        {
            Assert.AreEqual(false, true);
        }
    }
}