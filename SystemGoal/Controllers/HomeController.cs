using GoalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GoalSystem.Controllers
{
    /// <summary>
    /// HomeController
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index
        /// </summary>
        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "GoalSystems";

            IEnumerable<Car> cars = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50069/api/");

                var response = await client.GetAsync("car/GetAllCars");
                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsAsync<IList<Car>>();
                    cars = readTask.Result.ToList();
                }
                else
                {
                    cars = Enumerable.Empty<Car>();
                    ModelState.AddModelError(string.Empty, "Server error");
                }
            }

            return View(cars);
        }

    }
}
