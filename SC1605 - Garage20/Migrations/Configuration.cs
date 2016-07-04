using System.Collections.Generic;
using SC1605___Garage20.Models;

namespace SC1605___Garage20.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SC1605___Garage20.DataAccessLayer.VehicleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SC1605___Garage20.DataAccessLayer.VehicleContext context)
        {
            var vehicleList = new List<Vehicle>
            {
                new Vehicle
                {
                    Color = "Red",
                    NumberOfWheels = 4,
                    Owner = "Anna Albertsson",
                    RegistrationNumber = "ABC123",
                    VehicleType = VehicleType.Car,
                    ParkedDate = DateTime.Now,
                    EndParkedDate = DateTime.Now.AddDays(2)
                },
                new Vehicle
                {
                    Color = "Blue",
                    NumberOfWheels = 2,
                    Owner = "Anna Albertsson",
                    RegistrationNumber = "DEF456",
                    VehicleType = VehicleType.MotorCycle,
                    ParkedDate = DateTime.Now,
                    EndParkedDate = DateTime.Now.AddDays(2)
                },
                new Vehicle
                {
                    Color = "Yellow",
                    NumberOfWheels = 6,
                    Owner = "Ceasar Certifikat",
                    RegistrationNumber = "GHI789",
                    VehicleType = VehicleType.Truck,
                    ParkedDate = DateTime.Now,
                    EndParkedDate = DateTime.Now.AddDays(2)
                },
                new Vehicle
                {
                    Color = "Blue",
                    NumberOfWheels = 4,
                    Owner = "David Danielsson",
                    RegistrationNumber = "ABC345",
                    VehicleType = VehicleType.Car,
                    ParkedDate = DateTime.Now,
                    EndParkedDate = DateTime.Now.AddDays(2)
                },
                new Vehicle
                {
                    Color = "White",
                    NumberOfWheels = 0,
                    Owner = "Bengt Bertilsson",
                    RegistrationNumber = "DEF234",
                    VehicleType = VehicleType.Boat,
                    ParkedDate = DateTime.Now,
                    EndParkedDate = DateTime.Now.AddDays(2)
                }
            };

            context.Vehicles.AddOrUpdate(vehicleList.ToArray());


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}