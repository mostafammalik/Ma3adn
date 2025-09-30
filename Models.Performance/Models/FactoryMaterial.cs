using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{
    public class FactoryMaterial
    {
        public Guid FactoryId { get; set; }
        public Factory Factory { get; set; }

        public Guid MaterialId { get; set; }
        public Material Material { get; set; }
    }

}
