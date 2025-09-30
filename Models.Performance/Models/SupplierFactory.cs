using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class SupplierFactory
    {
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public Guid FactoryId { get; set; }
        public Factory Factory { get; set; }
    }

}
