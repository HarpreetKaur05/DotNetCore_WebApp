using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Int32 CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

        public Int32? ModifiedBy = null;

        public DateTime? ModifiedDate = null;
    }
}
