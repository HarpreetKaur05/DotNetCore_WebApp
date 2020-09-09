using System;
using MVCCore.Models;
using MediatR;


namespace MVCCore.Mediator.Request
{
    public class LoginRequest : Login, IRequest<bool>
    {


    }
}
