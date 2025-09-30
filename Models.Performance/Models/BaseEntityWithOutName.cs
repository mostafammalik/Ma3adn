using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public  class BaseEntityWithOutName
    {
        public Guid Id { set; get; }

        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { set; get; }
    }
}
