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
    public class AnswerControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AnswerControllerReturnsCorectAnswer()
        {
            //initilize
            Answer answer = new Answer { Id = 1, AnswerText = "Отговор 1", Correct = 1, WrongText = "" };
            Answer answer2 = new Answer { Id = 2, AnswerText = "Отговор 2", Correct = 0, WrongText = "" };
            Answer answer3 = new Answer { Id = 3, AnswerText = "Отговор 3", Correct = 0, WrongText = "" };

            var data = new List<Answer> { answer, answer2, answer3 }.AsQueryable();
            var mockSet = new Mock<DbSet<Answer>>();

            mockSet.As<IQueryable<Answer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Answer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Answer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Answer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<Brainzzler_DBContext>();

            mockContext.Setup(set => set.Answers).Returns(mockSet.Object);

            //Act
            var service = new AnswersController(mockContext.Object);
            var answ = service.GetAnswer(2).Value.Id;

            //Assert
            Assert.AreEqual(answer2.Id, answ);
        }

        [Test]
        public void AnswerControllerReturnsNotFound()
        {
            //initilize
            Answer answer = new Answer { Id = 1, AnswerText = "Отговор 1", Correct = 1, WrongText = "" };
            Answer answer2 = new Answer { Id = 2, AnswerText = "Отговор 2", Correct = 0, WrongText = "" };
            Answer answer3 = new Answer { Id = 3, AnswerText = "Отговор 3", Correct = 0, WrongText = "" };

            var data = new List<Answer> { answer, answer2, answer3 }.AsQueryable();
            var mockSet = new Mock<DbSet<Answer>>();

            mockSet.As<IQueryable<Answer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Answer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Answer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Answer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<Brainzzler_DBContext>();

            mockContext.Setup(set => set.Answers).Returns(mockSet.Object);

            //Act
            var service = new AnswersController(mockContext.Object);
            var answ = service.GetAnswer(4);

            //Assert
            Assert.AreEqual(null, answ.Value);
        }
    }
}