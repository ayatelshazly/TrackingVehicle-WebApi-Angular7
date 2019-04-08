using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TrackingVehiclesTask.BLL;
using TrackingVehiclesTask.BLL.DTO;

namespace TrackingVehiclesTask.Api.Controllers
{
    public class CustomerController : ApiController
    {
        protected readonly VehicleTrackingBusiness _vehicleTrackingBusiness;
        public List<CustomerDTO> listofcutomers = new List<CustomerDTO>();

        public CustomerController()
        {
            _vehicleTrackingBusiness = new VehicleTrackingBusiness();
        }
        //public CustomerController(List<CustomerDTO> listofcutomers)
        //{
        //    _vehicleTrackingBusiness = new VehicleTrackingBusiness();
        //    this.listofcutomers = listofcutomers;
        //}


        // GET api/values
        [HttpGet]
        [Route("AllCustomersDetails")]
        public IEnumerable<CustomerDTO> Get()
        {

            IEnumerable<CustomerDTO> cusomersList = _vehicleTrackingBusiness.GetCustomers().ToList();

            Random randomStatus = new Random();
            foreach (CustomerDTO _customer in cusomersList)
            {
                foreach (VehicleDTO Veh in _customer.Vehicle)
                {

                    int ZeroOne = RandomZeroOne(randomStatus);
                    Veh.Status = Convert.ToByte(ZeroOne);
                }
            }
            return cusomersList;
        }


        static int RandomZeroOne(Random random)
        {
            int rnd = random.Next(2);
            return rnd;
        }
    }
}