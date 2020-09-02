using MediatR; 
using MVCCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using MVCCore.Models;
using MVCCore.BL;
using MVCCore.Mediator.Request;

namespace MVCCore.Mediator.Handler
{
    public class LoginHandler : IRequestHandler<LoginRequest, string>
    {
        private readonly ILogin _login;
        public LoginHandler(ILogin login)
        {
            _login = login;
        }
      
        public Task<string> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var response = _login.ValidateUser(request.UserName, request.Password);
            return Task.FromResult(response);
        }
    }
}