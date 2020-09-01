using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Models
{
    public class Login  
    {
        [Key]
        [Column] 
        public Int32 UserId { get; set; }
        [Required]

        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
      
        public Int32 CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }

        public bool IsActive { get; set; }

        [AllowNull]
        public Int32 ModifiedBy { get; set; }
        [AllowNull]
        public DateTime ModifiedDate { get; set; }
    }

    
}
