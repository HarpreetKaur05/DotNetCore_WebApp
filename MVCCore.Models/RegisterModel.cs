using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVCCore.Models
{
   public class RegisterModel
    {
        [Key]
        public Int32 UserId { get; set; }

        [Display(Name = "User Name")]
        [MaxLength(50)]
        public string UserName { get; set; }
        
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Display(Name = "Set Password")]
        [MaxLength(50)]
        public string Password { get; set; }

        [NotMapped]
        [Display(Name = "Confirm Password")]
        [MaxLength(50)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        public Int32 CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

        public Int32? ModifiedBy = null;

        public DateTime? ModifiedDate = null;
    }
}
