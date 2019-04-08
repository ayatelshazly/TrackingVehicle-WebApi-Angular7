using System;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using System.Collections.Generic;
using TrackingVehiclesTask.BLL.DTO;
using TrackingVehiclesTask.SignalRSimulation;
using TrackingVehiclesTask.BLL;

namespace TrackingVehicles.Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<String> Vehicles = new List<string>() { "ABC123", "DEF456", "GHI789", "JKL012", "MNO345", "PQR678", "STU901" };
            VehicleTrackingBusiness vehicleTrackingBusiness = new VehicleTrackingBusiness();
            var customers = vehicleTrackingBusiness.GetCustomers();

            string url = "http://localhost:8095";
            using (WebApp.Start(url))
            {
                Console.WriteLine("Server running on {0}", url);
                while (true)
                {
                    System.Threading.Thread.Sleep(6000);

                    IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<TrackingHub>();

                    //Send random status
                    Random randomStatus = new Random();

                    foreach (CustomerDTO _customer in customers )
                    {
                        foreach (VehicleDTO car in _customer.Vehicle)
                        {
                            int i = GenerateDigit(randomStatus);
                            //car.Status = i;
                            hubContext.Clients.All.SendVehicleStatus(car);

                            System.Threading.Thread.Sleep(60);

                        }
                    }

                    Console.WriteLine("Server Sending Vehicle Status\n");
                }

            }
        }

        static int GenerateDigit(Random rng)
        {

            return rng.Next(2);
        }

        
    }
}
