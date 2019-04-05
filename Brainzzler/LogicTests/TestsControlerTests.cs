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
        public Mock<DbSet<Test>> mockSet;
        public Mock<Brainzzler_DBContext> mockContext;
        public Test test;

        [SetUp]
        public void Setup()
        {
            //Initialize
            Answer answer = new Answer { Id = 1, AnswerText = "Отговор 1", Correct = 1, WrongText = "" };
            Answer answer2 = new Answer { Id = 2, AnswerText = "Отговор 2", Correct = 0, WrongText = "" };
            Answer answer3 = new Answer { Id = 3, AnswerText = "Отговор 3", Correct = 0, WrongText = "" };
            List<Answer> answers = new List<Answer> { answer, answer2, answer3 };

            Question question = new Question { Answers = answers, Id = 1, QuestionText = "Въпрос", Score = 2, WrongText = "" };
            List<Question> questions = new List<Question> { question };

            test = new Test { Id = 1, Test_Name = "Начално ниво", Questions = questions };
            var data = new List<Test> { test }.AsQueryable();

            mockSet = new Mock<DbSet<Test>>();
            mockSet.As<IQueryable<Test>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Test>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Test>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Test>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            mockContext = new Mock<Brainzzler_DBContext>();
            mockContext.Setup(set => set.Tests).Returns(mockSet.Object);
        }

        [Test]
        public void TestControllerReturnsCorrectTestIndex()
        {
            //Act
            var controller = new TestsController(mockContext.Object);
            var TestResult = controller.Index() as ViewResult;
            var model = (List<Test>)TestResult.ViewData.Model;
            //Assert
            Assert.AreEqual(test, model.FirstOrDefault(c => c.Test_Name == "Начално ниво"));
        }

        [Test]
        public void TestControllerDetailsReturnsCorrectTestById()
        {
            var controller = new TestsController(mockContext.Object);
            var detailsResult = controller.Details(1);
            //TODO

            Assert.AreEqual(false, true);
        }

        [Test]
        public void TestControllerCreateReturnsCorrectView()
        {
            var controller = new TestsController(mockContext.Object);
            var CreateResult = controller.Create() as ViewResult;

            //Assert
            Assert.AreEqual("Create", CreateResult.ViewName);
        }

        [Test]
        public void TestControllerCreateSaveChangesDatabase()
        {
            //TODO
            Assert.AreEqual(true, false);
        }

        [Test]
        public void TestControllerEditFindsCorrectTest()
        {
            //TODO
            Assert.AreEqual(true, false);
        }

        [Test]
        public void TestControllerEditSavesChangesCorrect()
        {
            //TODO
            Assert.AreEqual(true, false);
        }

        [Test]
        public void TestControllerDeleteReturnsCorrectView()
        {
            //TODO
            Assert.AreEqual(true, false);
        }

        [Test]
        public void TestControllerDeleteConfirmedSavesChangesCorrect()
        {
            //TODO
            Assert.AreEqual(true, false);
        }


    }
}
