using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingVehiclesTask.BLL.DTO
{
    public class VehicleDTO
    {
        
        public int Id { get; set; }
        public string VIN { get; set; }
        public string RegNo { get; set; }
        public int CustomerId { get; set; }
        public CustomerDTO Customer { get; set; }
        public byte Status { get; set; }
       
    }
    public enum Status
    {
        Active = 1,
        NotActive = 2
    }
}
