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
        public void AnswerSheetsControllerReturnsNoContent()
        {
            //initialize
            Answer answer = new Answer { Id = 1, AnswerText = "Отговор 1", Correct = 1, WrongText = "" };
            Answer answer2 = new Answer { Id = 2, AnswerText = "Отговор 2", Correct = 0, WrongText = "" };
            Answer answer3 = new Answer { Id = 3, AnswerText = "Отговор 3", Correct = 0, WrongText = "" };
            List<Answer> answers = new List<Answer> { answer, answer2, answer3 };

            Question question = new Question { Answers = answers, Id = 1, QuestionText = "Въпрос", Score = 2, WrongText = "" };
            List<Question> questions = new List<Question> { question };

            Test test = new Test { Id = 1, Test_Name = "Начално ниво", Questions = questions };

            var questionResponse = new QuestionResponse { Id = 1, Question = question, SelectedAnswers = new List<Answer> { answer }, TextAnswer = "" };
            List<QuestionResponse> questionResponses = new List<QuestionResponse> { questionResponse };

            Score score = new Score { Id = 1, CurrentScore = 2, MaxScore = 2, Note = "" };

            var answerSheet = new AnswerSheet { Id = 1, QuestionResponses = questionResponses, Score = score, Test = test, UserId = "1", UserName = "TestUser" };

            var mockContext = new Mock<Brainzzler_DBContext>();

            //act
            var controller = new AnswerSheetsController(mockContext.Object);
            var result = controller.PutAnswerSheet(1, answerSheet);

            //assert
            Assert.AreEqual(mockContext.Object.AnswerSheet.FirstOrDefault(c => c.Id == 1), answerSheet);

        }
    }
}