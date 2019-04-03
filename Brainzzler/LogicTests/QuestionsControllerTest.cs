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

namespace Tests
{
    public class QuestionsControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QuestionControllerReturnsCorectAnswer()
        {
            //initilize

            Answer answer = new Answer { Id = 1, AnswerText = "Отговор 1", Correct = 1, WrongText = "" };
            Answer answer2 = new Answer { Id = 2, AnswerText = "Отговор 2", Correct = 0, WrongText = "" };
            Answer answer3 = new Answer { Id = 3, AnswerText = "Отговор 3", Correct = 0, WrongText = "" };
            List<Answer> answers = new List<Answer> { answer, answer2, answer3 };

            Question question = new Question { Answers = answers, Id = 1, QuestionText = "Въпрос", Score = 2, WrongText = "" };

            var data = new List<Question> { question }.AsQueryable();
            var mockSet = new Mock<DbSet<Question>>();

            mockSet.As<IQueryable<Question>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Question>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Question>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Question>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<Brainzzler_DBContext>();

            mockContext.Setup(set => set.Questions).Returns(mockSet.Object);

            //Act
            var service = new QuestionsController(mockContext.Object);
            var quest = service.GetQuestion(1).Value.Id;

            //Assert
            Assert.AreEqual(question.Id, quest);
        }
        
        [Test]
        public void QuestionControllerReturnsCorectAnswer2()
        {
            //initilize
            Answer answer = new Answer { Id = 1, AnswerText = "Отговор 1", Correct = 1, WrongText = "" };
            Answer answer2 = new Answer { Id = 2, AnswerText = "Отговор 2", Correct = 0, WrongText = "" };
            Answer answer3 = new Answer { Id = 3, AnswerText = "Отговор 3", Correct = 0, WrongText = "" };
            List<Answer> answers = new List<Answer> { answer, answer2, answer3 };

            Question question = new Question { Answers = answers, Id = 1, QuestionText = "Въпрос", Score = 2, WrongText = "" };

            var data = new List<Question> { question }.AsQueryable();
            var mockSet = new Mock<DbSet<Question>>();

            mockSet.As<IQueryable<Question>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Question>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Question>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Question>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<Brainzzler_DBContext>();

            mockContext.Setup(set => set.Questions).Returns(mockSet.Object);

            //Act
            var service = new QuestionsController(mockContext.Object);
            var quest = service.GetQuestion(4);

            //Assert
            Assert.AreEqual(null, quest.Value);
        }
    }
}