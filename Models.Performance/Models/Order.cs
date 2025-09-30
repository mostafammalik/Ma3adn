using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class Order : BaseEntityWithOutName
    {
        public decimal Total { set; get; }

        // Foreign key to Customer 
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

}
