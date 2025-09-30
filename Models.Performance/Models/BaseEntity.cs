using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.Models
{

    public  class BaseEntity 
    { 
        public Guid Id { set; get; }
        public String? NameAr { get; set; }
        public String? NameEn { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public string? CreatedBy { set; get; }
    } 

}
