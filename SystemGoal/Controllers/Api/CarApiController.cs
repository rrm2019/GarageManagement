using GoalSystem.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using SystemGoal.Context;

namespace GoalSystem.Controllers.Api
{
    /// <summary>
    /// Car Api
    /// </summary>
    public class CarApiController : ApiController
    {
        private DatabaseContext context = new DatabaseContext();

        /// <summary>
        /// Get All Cars
        /// </summary>
        /// <remarks>
        /// Get a list of all cars
        /// </remarks>
        /// <returns></returns>
        /// <response code ="200"></response>
        [Route("api/car/GetAllCars")]
        public IHttpActionResult GetCars()
        {
            var cars = context.Cars.ToList();

            if (cars.Count == 0)
            {
                return NotFound();
            }

            return Ok(cars);
        }

        /// <summary>
        /// Get Car
        /// </summary>
        /// <remarks>
        /// Get select car
        /// </remarks>
        /// <returns></returns>
        [Route("api/car/GetCar/{id}")]
        [ResponseType(typeof(Car))]
        public IHttpActionResult GetCar(int id)
        {
            var car = context.Cars.Where(c => c.Id == id).FirstOrDefault();

            if (car == null)
            {
                return NotFound();
            }

            return Ok(car);
         }

        /// <summary>
        /// Post Car
        /// </summary>
        /// <remarks>
        /// Save a new car
        /// </remarks>
        /// <returns></returns>
        [Route("api/car/AddCar")]
        [ResponseType(typeof(Car))]
        public IHttpActionResult PostCar([FromBody]Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Cars.Add(car);
            context.SaveChanges();
            CreatedAtRoute("DefaultApi", new { id = car.Id }, car);

            return Ok(car);
        }

        /// <summary>
        ///Put Car
        /// </summary>
        /// <remarks>
        /// Update select car
        /// </remarks>
        /// <returns></returns>
        [Route("api/car/EditCar/{id}")]
        [ResponseType(typeof(Car))]
        public IHttpActionResult PutCar(int id, [FromBody]Car car)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != car.Id)
            {
                return BadRequest();
            }

            context.Entry(car).State = EntityState.Modified;

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return Ok(car);
        }

        /// <summary>
        /// Delete Car
        /// </summary>
        /// <remarks>
        /// Remove select car
        /// </remarks>
        /// <returns></returns>
        [Route("api/car/DeleteCar")]
        [ResponseType(typeof(Car))]
        public IHttpActionResult DeleteCar(int id)
        {
            Car car = context.Cars.Find(id);
            if (car == null)
            {
                return NotFound();
            }

            context.Cars.Remove(car);
            context.SaveChanges();

            return Ok(car);
        }
    }
}
