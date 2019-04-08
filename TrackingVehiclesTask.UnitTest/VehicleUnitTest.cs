using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrackingVehiclesTask.Api.Controllers;
using TrackingVehiclesTask.BLL;
using TrackingVehiclesTask.BLL.DTO;
using TrackingVehiclesTask.BLL.MapperConfig;

namespace TrackingVehiclesTask.UnitTest
{
    [TestClass]
    public class VehicleUnitTest
    {
        VehicleTrackingBusiness _vehicleTrackingBusiness;

        public VehicleUnitTest()
        {
            _vehicleTrackingBusiness = new VehicleTrackingBusiness();
        }


        [TestMethod]
        public void Get_AllVehicle_TestMethod()
        {             
            int counVehicles = 0;
            var testVehciles = GetTestVehicles();
            var CustController = new CustomerController();
            List<CustomerDTO> result = CustController.Get() as List<CustomerDTO>;
            foreach (CustomerDTO cust in result)
            {
                counVehicles += cust.Vehicle.Count();
            }
            Assert.AreEqual(testVehciles.Count, counVehicles);
        }

        [TestMethod]
        public void Vehicle_FindVIN_TestMethod()
        {
            List<VehicleDTO> testVehicles = GetTestVehicles();
            var CustController = new CustomerController();
            List<CustomerDTO> result = CustController.Get() as List<CustomerDTO>;
            List<VehicleDTO> Vlist = new List<VehicleDTO>(); ;

            foreach (CustomerDTO cust in result)
            {
                Vlist.AddRange(cust.Vehicle);
            }
            Assert.AreEqual(Vlist[0].VIN.ToString(), testVehicles[0].VIN.ToString());
        }

        [TestMethod]
        public void Vehicle_ListIsIdentical_TestMethod()
        {
            List<VehicleDTO> testVehicles = GetTestVehicles();
            var CustController = new CustomerController();

            List<CustomerDTO> result = CustController.Get() as List<CustomerDTO>;
            List<VehicleDTO> Vlist = new List<VehicleDTO>(); ;

            foreach (CustomerDTO cust in result)
            {
                Vlist.AddRange(cust.Vehicle);
            }
            
            for (int i = 0; i < Vlist.Count(); i++)
            {
                Assert.AreEqual(Vlist[i].VIN, testVehicles[i].VIN.ToString());
                Assert.AreEqual(Vlist[i].RegNo, testVehicles[i].RegNo.ToString());
                Assert.AreEqual(Vlist[i].CustomerId.ToString(), testVehicles[i].CustomerId.ToString());
            }

        }


        private List<VehicleDTO> GetTestVehicles()
        {
            var testVehicle = new List<VehicleDTO>();
            testVehicle.Add(new VehicleDTO { VIN = "YS2R4X20005399401", RegNo = "ABC123", CustomerId = 1, Status = 0 });
            testVehicle.Add(new VehicleDTO { VIN = "VLUR4X20009093588", RegNo = "DEF456", CustomerId = 1, Status = 0 });
            testVehicle.Add(new VehicleDTO { VIN = "VLUR4X20009048066", RegNo = "GHI789", CustomerId = 1, Status = 0 });

            testVehicle.Add(new VehicleDTO { VIN = "YS2R4X20005388011", RegNo = "ABC123", CustomerId = 2, Status = 0 });
            testVehicle.Add(new VehicleDTO { VIN = "YS2R4X20005387949", RegNo = "DEF456", CustomerId = 2, Status = 0 });

            testVehicle.Add(new VehicleDTO { VIN = "VLUR4X20009048066", RegNo = "PQR678", CustomerId = 3, Status = 0 });
            testVehicle.Add(new VehicleDTO { VIN = "YS2R4X20005387055", RegNo = "STU901", CustomerId = 3, Status = 0 });

            return testVehicle;
        }
    }
}
