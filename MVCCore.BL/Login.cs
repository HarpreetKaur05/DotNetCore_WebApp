using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MVCCore.Models;
using AppContext = MVCCore.Models.AppContext;

namespace MVCCore.BL
{
    public class Login : ILogin, IRequest<int>
    {
        private readonly AppContext _dbContext;

        public Login(AppContext context)
        {
            _dbContext = context;
        }

        public async Task<int> ValidateUser(string username, string password)
        {
            var response = await _dbContext.Login.Where(x => x.UserName == username && x.Password == password).Select(x => x.UserId).FirstOrDefaultAsync();
            return response;
        }
    }     

}
