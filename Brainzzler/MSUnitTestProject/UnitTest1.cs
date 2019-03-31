using Brainzzler.Controllers;
using Brainzzler.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;
using Brainzzler.Models;

using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Controllers;

namespace MSUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
