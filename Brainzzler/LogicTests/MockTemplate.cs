using System;
using System.Collections.Generic;
using System.Text;
using Brainzzler.Controllers;
using Brainzzler.Models;
using NUnit.Framework;
using Moq;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LogicTests
{
    class MockTemplate
    {
        public void MockTemplateContext()
        {
            //initialize
            Answer answer = new Answer { Id = 1, AnswerText = "Отговор 1", Correct = 1, WrongText = "" };
            Answer answer2 = new Answer { Id = 2, AnswerText = "Отговор 2", Correct = 0, WrongText = "" };
            Answer answer3 = new Answer { Id = 3, AnswerText = "Отговор 3", Correct = 0, WrongText = "" };
            List<Answer> answers = new List<Answer> { answer, answer2, answer3 };
            var data1 = new List<Answer> { answer, answer2, answer3 }.AsQueryable();
            var mockAnswer = new Mock<DbSet<Answer>>();
            mockAnswer.As<IQueryable<Answer>>().Setup(m => m.Provider).Returns(data1.Provider);
            mockAnswer.As<IQueryable<Answer>>().Setup(m => m.Expression).Returns(data1.Expression);
            mockAnswer.As<IQueryable<Answer>>().Setup(m => m.ElementType).Returns(data1.ElementType);
            mockAnswer.As<IQueryable<Answer>>().Setup(m => m.GetEnumerator()).Returns(data1.GetEnumerator());


            Question question = new Question { Answers = answers, Id = 1, QuestionText = "Въпрос", Score = 2, WrongText = "" };
            List<Question> questions = new List<Question> { question };
            var data2 = new List<Question> { question }.AsQueryable();
            var mockQuestion = new Mock<DbSet<Question>>();
            mockQuestion.As<IQueryable<Question>>().Setup(m => m.Provider).Returns(data2.Provider);
            mockQuestion.As<IQueryable<Question>>().Setup(m => m.Expression).Returns(data2.Expression);
            mockQuestion.As<IQueryable<Question>>().Setup(m => m.ElementType).Returns(data2.ElementType);
            mockQuestion.As<IQueryable<Question>>().Setup(m => m.GetEnumerator()).Returns(data2.GetEnumerator());


            var questionResponse = new QuestionResponse { Id = 1, Question = question, SelectedAnswers = new List<Answer> { answer }, TextAnswer = "" };
            List<QuestionResponse> questionResponses = new List<QuestionResponse> { questionResponse };
            var data3 = new List<QuestionResponse> { questionResponse }.AsQueryable();
            var mockQuestionR = new Mock<DbSet<QuestionResponse>>();
            mockQuestionR.As<IQueryable<QuestionResponse>>().Setup(m => m.Provider).Returns(data3.Provider);
            mockQuestionR.As<IQueryable<QuestionResponse>>().Setup(m => m.Expression).Returns(data3.Expression);
            mockQuestionR.As<IQueryable<QuestionResponse>>().Setup(m => m.ElementType).Returns(data3.ElementType);
            mockQuestionR.As<IQueryable<QuestionResponse>>().Setup(m => m.GetEnumerator()).Returns(data3.GetEnumerator());

            Score score = new Score { Id = 1, CurrentScore = 2, MaxScore = 2, Note = "" };
            var data4 = new List<Score> { score }.AsQueryable();
            var mockScore = new Mock<DbSet<Score>>();
            mockScore.As<IQueryable<Score>>().Setup(m => m.Provider).Returns(data4.Provider);
            mockScore.As<IQueryable<Score>>().Setup(m => m.Expression).Returns(data4.Expression);
            mockScore.As<IQueryable<Score>>().Setup(m => m.ElementType).Returns(data4.ElementType);
            mockScore.As<IQueryable<Score>>().Setup(m => m.GetEnumerator()).Returns(data4.GetEnumerator());

            Test test = new Test { Id = 1, Test_Name = "Начално ниво", Questions = questions };
            var data5 = new List<Test> { test }.AsQueryable();
            var mockTest = new Mock<DbSet<Test>>();
            mockTest.As<IQueryable<Test>>().Setup(m => m.Provider).Returns(data5.Provider);
            mockTest.As<IQueryable<Test>>().Setup(m => m.Expression).Returns(data5.Expression);
            mockTest.As<IQueryable<Test>>().Setup(m => m.ElementType).Returns(data5.ElementType);
            mockTest.As<IQueryable<Test>>().Setup(m => m.GetEnumerator()).Returns(data5.GetEnumerator());

            var answerSheet = new AnswerSheet { Id = 1, QuestionResponses = questionResponses, Score = score, Test = test, UserId = "1", UserName = "TestUser" };
            var data = new List<AnswerSheet> { answerSheet }.AsQueryable();
            var mockSet = new Mock<DbSet<AnswerSheet>>();
            mockSet.As<IQueryable<AnswerSheet>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<AnswerSheet>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<AnswerSheet>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<AnswerSheet>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var user = new AspNetUsers { Id = "1", UserName = "TestUser", NormalizedUserName = "TESTUSER", Email = "test@google.com", NormalizedEmail = "TEST@GOOGLE.COM", EmailConfirmed = false, PasswordHash = "AQAAAAEAACcQAAAAEDRMWdzHFXGRE3SgwHOq8nNPbPlucCQjPRkfK54J9YXxCjg7p2fk6Q1S83UnNINPFw==", SecurityStamp = "M6KU2AJELWWYDCKBRZOJS6TZ4S2O3J3U", ConcurrencyStamp = "93de2d96-9c3f-4c51-8676-4ca10ab68656", PhoneNumber = "NULL", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 };
            var data6 = new List<AspNetUsers> { user }.AsQueryable();
            var mockUser = new Mock<DbSet<AspNetUsers>>();
            mockSet.As<IQueryable<AspNetUsers>>().Setup(m => m.Provider).Returns(data6.Provider);
            mockSet.As<IQueryable<AspNetUsers>>().Setup(m => m.Expression).Returns(data6.Expression);
            mockSet.As<IQueryable<AspNetUsers>>().Setup(m => m.ElementType).Returns(data6.ElementType);
            mockSet.As<IQueryable<AspNetUsers>>().Setup(m => m.GetEnumerator()).Returns(data6.GetEnumerator());

            var mockContext = new Mock<Brainzzler_DBContext>();
            mockContext.Setup(set => set.AnswerSheet).Returns(mockSet.Object);
            mockContext.Setup(set => set.Answers).Returns(mockAnswer.Object);
            mockContext.Setup(set => set.Questions).Returns(mockQuestion.Object);
            mockContext.Setup(set => set.QuestionResponse).Returns(mockQuestionR.Object);
            mockContext.Setup(set => set.Score).Returns(mockScore.Object);
            mockContext.Setup(set => set.Tests).Returns(mockTest.Object);
            mockContext.Setup(set => set.AspNetUsers).Returns(mockUser.Object);
        }
    }
}
