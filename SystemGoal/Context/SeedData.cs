using GoalSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SystemGoal.Context
{
    /// <summary>
    /// SeedData
    /// </summary>
    public class SeedData : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        /// <summary>
        /// Seed
        /// </summary>
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);

            var dataSet = new List<Car>
            {
                new Car{ Make = "Opel", Model = "Corsa", CarRegistration = "1234RRD", CarReview = new DateTime(2019,07,17,12,00,00), Kilometers = 12234, Status = 1},
                new Car{ Make = "Volvo", Model = "v40", CarRegistration = "1485FFD", CarReview = new DateTime(2019,07,25,12,00,00), Kilometers = 74858, Status = 1},
                new Car{ Make = "Volkswagen", Model = "Golf", CarRegistration = "1323SDS", CarReview = new DateTime(2019,07,14,12,00,00), Kilometers = 150245, Status = 2}
            };
            dataSet.ForEach(e => context.Cars.Add(e));
            context.SaveChanges();
}
    }
}