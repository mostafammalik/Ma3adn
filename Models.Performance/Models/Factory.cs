using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class Factory : BaseEntity
    {
        public required string Location { set; get; }
        public required string Specification { set; get; }

        // Many-to-many relationship with Material
        public ICollection<Material> Materials { set; get; } =new List<Material>();
        public ICollection<Supplier> Suppliers  { set; get; } = new List<Supplier>();

    }

}
