using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace MVCCore.BL
{
    public class Login : ILogin, IRequest<string>
    {
        private readonly LoginContext _dbContext;

        public Login(LoginContext context)
        {
            _dbContext = context;
        }

        public string ValidateUser(string username, string password)
        {
            var response = _dbContext.Login.Where(x => x.UserName == username && x.Password == password).Select(x => x.UserId).FirstOrDefault();
            return response.ToString();

        }
    }     

}
