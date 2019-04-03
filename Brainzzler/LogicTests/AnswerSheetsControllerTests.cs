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
            var controller = new AnswerSheetsController();
            var AnswerSheetsResult = controller.Index() as ViewResult;

            Assert.AreEqual(NoContentResult, AnswerSheetsResult.ViewName);

        }
    }
}