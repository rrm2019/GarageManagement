using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using GoalSystem.Controllers.Api;
using GoalSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoalSystemTest
{
    [TestClass]
    public class CarApiControllerTest
    {
        [TestMethod]
        public void GetAllCars()
        {
            CarApiController controller = new CarApiController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var result = controller.GetCars() as List<Car>;
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void GetCar()
        {
            CarApiController controller = new CarApiController();
            Car car = new Car();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            car = controller.GetCar(2) as Car;
            Assert.AreEqual(2, car.Id);
        }

        [TestMethod]
        public void GetCarReturnNotFound()
        {
            CarApiController controller = new CarApiController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            IHttpActionResult actionResult = controller.GetCar(9);
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }

    }
}
