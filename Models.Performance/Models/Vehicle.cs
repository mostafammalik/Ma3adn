using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class Vehicle : BaseEntity
    {
        public required string Number { get; set; }
        public string? Color { set; get; }

        // Many-to-many relationship with Driver
        public ICollection<Driver> Drivers { get; set; } = new List<Driver>();
    }


}
