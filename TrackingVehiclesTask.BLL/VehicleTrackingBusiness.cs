using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingVehiclesTask.BLL.DTO;
using TrackingVehiclesTask.DAL;
using TrackingVehiclesTask.DAL.Repos;

namespace TrackingVehiclesTask.BLL
{
    public class VehicleTrackingBusiness
    {
        protected readonly CustomerRepository  _customerRepository;
        protected readonly VehicleRepository  _vehicleRepository;

        public VehicleTrackingBusiness()
        {
            var DB = new DBDataContext();
            _customerRepository = new CustomerRepository(DB);
            _vehicleRepository = new VehicleRepository(DB);
        }

        public IEnumerable<CustomerDTO> GetCustomers()
        {
            var test = _customerRepository.GetAll().ToList();

            var customers = _customerRepository.GetAll().ProjectTo<CustomerDTO>();
            return customers;
        }

    }
}
