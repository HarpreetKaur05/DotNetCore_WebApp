using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MVCCore.BL
{
    public class Login  : ILogin
    {
        public bool ValidateUser(string UserName, string Password)
        { 
            if (UserName == "Harpreet" && Password == "1234")
                return true;
            else
                return false;
        }
    }
}
