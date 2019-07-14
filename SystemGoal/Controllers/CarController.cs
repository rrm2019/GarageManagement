using GoalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SystemGoal.Controllers
{
    /// <summary>
    /// CarController
    /// </summary>
    public class CarController : Controller
    {
        /// <summary>
        /// Create View
        /// </summary>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Create post
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Create(Car car)
        {

            //Add Status available
            car.Status = 1;

            if(!ModelState.IsValid)
            {
                return RedirectToAction("Create");
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50069/api/");

                HttpResponseMessage response = await client.PostAsJsonAsync("car/AddCar", car);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error");
                }
            }

            return RedirectToAction("Index", "Home");

        }

        /// <summary>
        /// Edit status of car
        /// </summary>
        public async Task<ActionResult> Edit(int id)
        {
            TempData["message"] = "";
            Car car = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50069/api/");

                var response = await client.GetAsync("car/GetCar/" + id);
                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsAsync<Car>();
                    car = readTask.Result;

                    if (car.Status == 1)
                    {
                        car.Status = 2;
                        TempData["message"] = "toRoute";
                    }
                    else
                    {
                        car.Status = 1;
                        TempData["message"] = "toGarage";

                    }

                    //var status = car.Status == 1 ? car.Status = 2 : car.Status = 1;
                    //car.Status = status;

                    HttpResponseMessage result = await client.PutAsJsonAsync("car/EditCar/" + car.Id, car);
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Server error");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error");
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}