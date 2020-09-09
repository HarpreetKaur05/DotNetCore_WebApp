using MediatR;
using MVCCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCore.Mediator.Request
{
    public class RegisterRequest : RegisterModel, IRequest<bool>
    {

    }
}
