using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class Driver : BaseEntity
    {
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public string AppUserId { get; set; }   // PK is also FK
        public AppUser AppUser { get; set; }


    }

}
