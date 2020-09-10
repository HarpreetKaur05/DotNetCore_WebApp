using MediatR;
using MVCCore.BL; 
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MVCCore.Mediator.Request;

namespace MVCCore.Mediator.Handler
{
    public class RegisterHandler : IRequestHandler<RegisterRequest, bool>
    {
        private readonly IRegister _register;
        public RegisterHandler(IRegister register)
        {
            _register = register;
        }

        public async Task<bool> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            var response = await _register.CreateUserWithIdentity(request);
            return response;
        }
    }
}
