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
    public class HomeControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HomeControllerReturnsIndexView()
        {
            var controller = new HomeController();
            var homeResult = controller.Index() as ViewResult;

            Assert.AreEqual("Index", homeResult.ViewName);

        }

        [Test]
        public void HomeControllerReturnsPrivacyView()
        {

            var controller = new HomeController();
            var homeResult = controller.Privacy() as ViewResult;

            Assert.AreEqual("Privacy", homeResult.ViewName);
        }

        /*[Test]
        public void HomeControllerReturnsErrorView()
        {

            var controller = new HomeController();
            var homeResult = controller.Error() as ViewResult;

            Assert.AreEqual(new ErrorViewModel(), homeResult.ViewName);
        }*/
    }
}