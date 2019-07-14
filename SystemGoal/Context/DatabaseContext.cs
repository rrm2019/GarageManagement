using GoalSystem.Models;
using System.Data.Entity;


namespace SystemGoal.Context
{
    /// <summary>
    /// DatabaseContext
    /// </summary>
    public class DatabaseContext : DbContext
    {
        /// <summary>
        /// DatabaseConnection
        /// </summary>
        public DatabaseContext() : base("DefaultConnection") { }

        /// <summary>
        /// DbSetCar
        /// </summary>
        public DbSet<Car> Cars { get; set; }
    }
}