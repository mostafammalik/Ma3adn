using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class Customer:BaseEntity
    {  
        public ICollection<Order> Orders { set; get; } = new List<Order>();
        public string AppUserId { get; set; }   // PK is also FK
        public AppUser AppUser { get; set; }
    }
}
