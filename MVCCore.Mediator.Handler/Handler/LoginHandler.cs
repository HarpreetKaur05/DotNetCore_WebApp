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
    public class LoginHandler : IRequestHandler<LoginRequest, bool>
    {
        private readonly ILogin _login;
        public LoginHandler(ILogin login)
        {
            _login = login;
        }

        public async Task<bool> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var response = await _login.ValidateUserWithIdentity(request);
            return response;
        }
        
    }
}