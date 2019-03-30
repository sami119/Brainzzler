using NUnit.Framework;
using Brainzzler.Controllers;
using Brainzzler.Models;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Abstractions;
using System.Threading.Tasks;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           // Brainzzler_DBContext context;
           var context = new Brainzzler_DBContext();
            var controller = new TestsController(context);
            Task<IActionResult> result = controller.Details(1) ;
            //var result = controller.Details(1); //as ViewResult;
            Assert.Pass();
        }
    }
}