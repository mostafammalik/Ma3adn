using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class DriverVehicle
    {
        public Guid DriverId { get; set; }
        public Driver Driver { get; set; }
        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }

}
