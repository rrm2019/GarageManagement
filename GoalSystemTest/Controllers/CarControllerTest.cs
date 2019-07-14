using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using GoalSystem.Controllers.Api;
using GoalSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoalSystemTest
{
    [TestClass]
    public class CarControllerTest
    {
        [TestMethod]
        public void GetCar()
        {
            var controller = new SystemGoal.Controllers.CarController();
            var result = controller.Create() as ViewResult;
            Assert.AreEqual("Create", result.ViewName);
        }
    }
}
