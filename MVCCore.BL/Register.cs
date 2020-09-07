using MediatR;
using Microsoft.EntityFrameworkCore;
using MVCCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace MVCCore.BL
{
   public class Register : IRegister, IRequest<int>
    {
        private readonly Models.AppContext _dbContext;
        public static int intResponse = 0;
        public Register(Models.AppContext context)
        {
           _dbContext = context;
        }

        public async Task<int> SaveNewUser(RegisterModel register)
        {
            var boolResponse = CheckUserExistsOrNot(register.Email);
            if (boolResponse.Result == true)
            { return intResponse = 0; }
           else { 
            _dbContext.Add(register);
            intResponse =  await _dbContext.SaveChangesAsync();
            return intResponse  ;
                }
        }

        public async Task<bool> CheckUserExistsOrNot(string email)
        {
             var response =  await _dbContext.Register.Where(x => x.Email == email).Select(x => x.UserId).FirstOrDefaultAsync() ;
             if (response != 0)
                return true;
            else
                return false;              
        }

    }
}

