using MediatR;
using Microsoft.AspNetCore.Identity;
using MVCCore.Mediator.Request;
using System;
using System.Collections.Generic;
using System.Text;
using MVCCore.BL;
using System.Threading.Tasks;
using System.Threading;

namespace MVCCore.Mediator.Handler
{
    public  class RoleHandler : IRequestHandler<RoleRequest, bool>
    {
        private readonly IRole _role;
        public RoleHandler( IRole role)
        {
            _role = role;
                
        }
        public async Task<bool> Handle(RoleRequest request, CancellationToken cancellationToken)
        {
            var response = await _role.CreateRole(request);
            return response;
        }
    }
}
