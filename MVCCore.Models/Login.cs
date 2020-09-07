using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;


namespace MVCCore.Models
{
    public class Login  
    {
        [Key]
        public Int32 UserId { get; set; }
      
        [Display(Name = "Email")]
        public string Email { get; set; }
        
      
        [Display(Name = "Password")]       
        public string Password { get; set; }
         
    }    
}
