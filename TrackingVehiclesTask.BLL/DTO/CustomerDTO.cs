﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrackingVehiclesTask.BLL.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public virtual ICollection<VehicleDTO> Vehicle { get; set; }

    }
}
