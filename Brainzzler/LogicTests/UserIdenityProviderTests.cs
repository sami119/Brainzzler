using Brainzzler.Services;
using Microsoft.AspNetCore.Http;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace LogicTests
{
    public class UserIdenityProviderTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void UserIdenityProviderReturnsCorrectId()
        {
            var mockIHttpContextAccesor = new Mock<IHttpContextAccessor>();
            mockIHttpContextAccesor.Setup(s => s.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value).Returns("TestUser");

            var service = new UserIdenityProvider(mockIHttpContextAccesor.Object);
            var result = service.GetCurrentUserId();

            //Assert
            Assert.AreEqual("TestUser", result);
        }
    }
}
