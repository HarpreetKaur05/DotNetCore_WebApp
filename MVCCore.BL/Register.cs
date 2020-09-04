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
                     _dbContext.Add(register);
                     await _dbContext.SaveChangesAsync();
            return intResponse =1 ;
        }

        public async Task<int> CheckUserExistsOrNot(string email)
        {
              intResponse = await _dbContext.Register.Where(x => x.Email == email).Select(x => x.UserId).FirstOrDefaultAsync() ;
            return intResponse;
        }

    }
}

