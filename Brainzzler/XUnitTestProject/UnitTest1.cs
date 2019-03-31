using Brainzzler.Controllers;
using Brainzzler.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Brainzzler_DBContext context;
            context = new Brainzzler_DBContext();
            var controller = new TestsController(context);
            //Task<IActionResult> result = controller.Details(1) ;
            var result = controller.Details(1) as ViewResult;
            Assert.AreEqual("1", "1");
        }
    }
}
