namespace TrackingVehiclesTask.DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrackingVehiclesTask.DAL.DBDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TrackingVehiclesTask.DAL.DBDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.



            context.Customers.AddOrUpdate(new Customer
            {
                Id = 1,
                CustomerName = "Kalles Grustransporter AB",
                CustomerAddress = "Cementvägen 8, 111 11 Södertälje",
                Vehicle = new List<Vehicle>
                {
                    new Vehicle{Id =1 , CustomerId = 1, RegNo = "ABC123", VIN ="YS2R4X20005399401", Status = 1 },
                    new Vehicle{Id =1 , CustomerId = 1, RegNo = "DEF456", VIN ="VLUR4X20009093588", Status = 1 },
                    new Vehicle{Id =1 , CustomerId = 1, RegNo = "GHI789", VIN ="VLUR4X20009048066", Status = 1 }
                }
            });
            context.Customers.AddOrUpdate(new Customer
            {
                Id = 2,
                CustomerName = "Johans Bulk AB",
                CustomerAddress = "Balkvägen 12, 222 22 Stockholm",
                Vehicle = new List<Vehicle>
                {
                    new Vehicle{Id =2 , CustomerId = 1, RegNo = "ABC123", VIN ="YS2R4X20005388011", Status = 0 },
                    new Vehicle{Id =2 , CustomerId = 1, RegNo = "DEF456", VIN ="YS2R4X20005387949", Status = 1 }
                }
            });
            context.Customers.AddOrUpdate(new Customer
            {
                Id = 2,
                CustomerName = "Haralds Värdetransporter AB",
                CustomerAddress = "Budgetvägen 1, 333 33 Uppsala",
                Vehicle = new List<Vehicle>
                {
                    new Vehicle{Id =2 , CustomerId = 1, RegNo = "PQR678", VIN ="VLUR4X20009048066", Status = 0 },
                    new Vehicle{Id =2 , CustomerId = 1, RegNo = "STU901", VIN ="YS2R4X20005387055", Status = 1 }
                }
            });
        }
    }
}
