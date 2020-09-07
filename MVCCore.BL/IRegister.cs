using MVCCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.BL
{
    public interface IRegister 
    {
        public  Task<int> SaveNewUser(RegisterModel register);

        public Task<bool> CreateUserWithIdentity(RegisterModel register);

    }
}
