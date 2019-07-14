using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemGoal.Controllers;
using System.Web.Mvc;

namespace GoalSystem.Test
{
    [TestClass]
    class TestActionCarController
    {
        [TestMethod]
        public void GetCar()
        {
            CarController controller = new CarController();
            var result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
