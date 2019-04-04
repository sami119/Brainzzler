using Brainzzler.Controllers;
using Brainzzler.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicTests
{
    public class TestsControlerTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestControllerReturnsCorrectTestIndex()
        {
            //Initialize
            Answer answer = new Answer { Id = 1, AnswerText = "Отговор 1", Correct = 1, WrongText = "" };
            Answer answer2 = new Answer { Id = 2, AnswerText = "Отговор 2", Correct = 0, WrongText = "" };
            Answer answer3 = new Answer { Id = 3, AnswerText = "Отговор 3", Correct = 0, WrongText = "" };
            List<Answer> answers = new List<Answer> { answer, answer2, answer3 };

            Question question = new Question { Answers = answers, Id = 1, QuestionText = "Въпрос", Score = 2, WrongText = "" };
            List<Question> questions = new List<Question> { question };

            Test test = new Test { Id = 1, Test_Name = "Начално ниво", Questions = questions };
            var data = new List<Test> { test }.AsQueryable();
            var mockTest = new Mock<DbSet<Test>>();
            mockTest.As<IQueryable<Test>>().Setup(m => m.Provider).Returns(data.Provider);
            mockTest.As<IQueryable<Test>>().Setup(m => m.Expression).Returns(data.Expression);
            mockTest.As<IQueryable<Test>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockTest.As<IQueryable<Test>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<Brainzzler_DBContext>();
            mockContext.Setup(set => set.Tests).Returns(mockTest.Object);

            //Act
            var controller = new TestsController(mockContext.Object);
            var TestResult = controller.Details(1);

            //Assert
            Assert.AreEqual(test, TestResult.Result);
        }
    }
}
