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
    public class CustomerUnitTest
    {
     
        VehicleTrackingBusiness _vehicleTrackingBusiness;

        public CustomerUnitTest()
        {           
            _vehicleTrackingBusiness = new VehicleTrackingBusiness();
        }
    

        [TestMethod]
        public void Get_AllCustomers_TestMethod()
        {
            AutoMapperConfig.Initialize();
            var testCustomers = GetTestCustomersDetails();
            var CustController = new CustomerController();
            var result = CustController.Get() as List<CustomerDTO>; 
            Assert.AreEqual(testCustomers.Count, result.Count);
        }

        [TestMethod]
        public void Customer_FindName_TestMethod()
        {
            List<CustomerDTO> testCustomers = GetTestCustomersDetails();
            var CustController = new CustomerController();
            List<CustomerDTO> result = CustController.Get() as List<CustomerDTO>;
            var CustomerNameV = result.FirstOrDefault(cust => cust.CustomerName == testCustomers[0].CustomerName);
            Assert.AreEqual(CustomerNameV.CustomerName.ToString(), testCustomers[0].CustomerName.ToString());
        }

        [TestMethod]
        public void Customer_ListIsIdentical_TestMethod()
        {
            List<CustomerDTO> testCustomers = GetTestCustomersDetails();
            var CustController = new CustomerController();
            List<CustomerDTO> result = CustController.Get() as List<CustomerDTO>;
            for (int i = 0;i < result.Count();i++)
            {
                Assert.AreEqual(result[i].CustomerName, testCustomers[i].CustomerName.ToString());
                Assert.AreEqual(result[i].CustomerAddress, testCustomers[i].CustomerAddress.ToString());
                Assert.AreEqual(result[i].Id.ToString(), testCustomers[i].Id.ToString());
            }
        
        }

        private List<CustomerDTO> GetTestCustomersDetails()
        {
            var testSampleCustomers = new List<CustomerDTO>();
            var testSampleVehicle = new List<VehicleDTO>();
            testSampleVehicle.Add(new VehicleDTO { VIN = "YS2R4X20005399401", RegNo = "ABC123", CustomerId = 1, Status = 0 });
            testSampleVehicle.Add(new VehicleDTO { VIN = "VLUR4X20009093588", RegNo = "DEF456", CustomerId = 1, Status = 0 });
            testSampleVehicle.Add(new VehicleDTO { VIN = "VLUR4X20009048066", RegNo = "GHI789", CustomerId = 1, Status = 0 });

            testSampleVehicle.Add(new VehicleDTO { VIN = "YS2R4X20005388011", RegNo = "ABC123", CustomerId = 2, Status = 0 });
            testSampleVehicle.Add(new VehicleDTO { VIN = "YS2R4X20005387949", RegNo = "DEF456", CustomerId = 2, Status = 0 });

            testSampleVehicle.Add(new VehicleDTO { VIN = "VLUR4X20009048066", RegNo = "PQR678", CustomerId = 3, Status = 0 });
            testSampleVehicle.Add(new VehicleDTO { VIN = "YS2R4X20005387055", RegNo = "STU901", CustomerId = 3, Status = 0 });


            testSampleCustomers.Add(new CustomerDTO
            {
                Id = 1, CustomerName = "Kalles Grustransporter AB", CustomerAddress = "Cementvägen 8, 111 11 Södertälje",
                Vehicle = testSampleVehicle
            });


            testSampleCustomers.Add(new CustomerDTO
            {
                Id = 2,
                CustomerName = "Johans Bulk AB",
                CustomerAddress = "Balkvägen 12, 222 22 Stockholm",
                Vehicle = testSampleVehicle
            });


            testSampleCustomers.Add(new CustomerDTO
            {
                Id = 3,
                CustomerName = "Haralds Värdetransporter AB",
                CustomerAddress = "Budgetvägen 1, 333 33 Uppsala",
                Vehicle = testSampleVehicle
            });

            return testSampleCustomers;
        }
    }
}
