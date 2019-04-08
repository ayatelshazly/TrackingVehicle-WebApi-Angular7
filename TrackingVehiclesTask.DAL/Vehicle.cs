using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingVehiclesTask.DAL
{
   public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string VIN { get; set; }
        public string RegNo { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public byte Status { get; set; }

    }
}
