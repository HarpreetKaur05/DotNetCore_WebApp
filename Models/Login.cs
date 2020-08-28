using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore
{
    public class Login : IRequest<bool>
    {
        [Key]
        public string userId { get; set; }
        [Required]

        public string userName { get; set; }

        public string password { get; set; }

    }
}
