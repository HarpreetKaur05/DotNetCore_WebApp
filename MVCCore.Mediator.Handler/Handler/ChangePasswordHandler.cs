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
    public class ChangePasswordHandler : IRequestHandler<ChangePasswordRequest, bool>
    {
        private readonly IChangePassword _changepassword;

        public ChangePasswordHandler(IChangePassword changePassword)
        {
            _changepassword = changePassword;
        }

        public async Task<bool> Handle(ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            var response = await _changepassword.ChangeUserPassword(request);
            return response;
        }
    }
}
