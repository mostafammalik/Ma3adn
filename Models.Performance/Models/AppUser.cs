using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Performance.Domain.Models
{
    public class AppUser : IdentityUser
    {
       
        public required string NameAr { get; set; }
        public required string NameEn { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { set; get; }
      
        public required string IqamaNumber { get; set; }
        public bool IsActive { get; set; } = true;

        // One-to-many relationship with Order
      
    }

}
