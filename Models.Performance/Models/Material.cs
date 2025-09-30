using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class Material : BaseEntity
    { 
        public required decimal PriceForTon { get; set; }
        public string Description { get; set; }

        // Many-to-many relationship with Factory
        public ICollection<Factory>Factories { set; get; } = new List<Factory>();
    }

}
