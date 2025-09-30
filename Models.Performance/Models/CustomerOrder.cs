using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class CustomerOrder
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        // Optional: extra fields about the relation
        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
        public string? Notes { get; set; }
    }

}
