using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVCCore.Models
{
   public  class ChangePasswordModel
    {
       [Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }

        [Display(Name = "New Password")]
        public string Password { get; set; }


        [NotMapped]
        [Display(Name = "Confirm Password")]

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
