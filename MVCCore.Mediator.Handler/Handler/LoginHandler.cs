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
    public class LoginHandler : IRequestHandler<LoginRequest, int>
    {
        private readonly ILogin _login;
        public LoginHandler(ILogin login)
        {
            _login = login;
        }

        public async Task<int> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var response = await _login.ValidateUser(request.UserName, request.Password);

            return response;
        }
        
    }
}