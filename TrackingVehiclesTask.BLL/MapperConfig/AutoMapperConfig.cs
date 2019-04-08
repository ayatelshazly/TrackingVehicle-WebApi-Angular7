using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingVehiclesTask.BLL.DTO;
using TrackingVehiclesTask.DAL;

namespace TrackingVehiclesTask.BLL.MapperConfig
{

    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<Customer, CustomerDTO>().ReverseMap();
                config.CreateMap<Vehicle, VehicleDTO>()
                     .ForMember(x => x.Customer, src => src.MapFrom(s => s.Customer));
            });
         
         
        }
    }
}
