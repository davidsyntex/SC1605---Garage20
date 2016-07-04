using System.Data.Entity;
using SC1605___Garage20.Models;

namespace SC1605___Garage20.DataAccessLayer
{
    public class VehicleContext : DbContext
    {
        public VehicleContext() : base("DefaultConnection")
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}