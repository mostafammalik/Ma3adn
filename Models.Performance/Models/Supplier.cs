using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class Supplier : BaseEntity
    {
    

        // Many-to-many relationship with Factory
        public ICollection<Factory> Factories { set; get; } = new List<Factory>();
        public string AppUserId { get; set; }   // PK is also FK
        public AppUser AppUser { get; set; }
    }

}
