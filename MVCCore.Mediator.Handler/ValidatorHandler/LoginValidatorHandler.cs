using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using MVCCore.Mediator.Request;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MVCCore.Mediator.Handler.ValidatorHandler
{
    public class LoginValidatorHandler : AbstractValidator<LoginRequest>
    {
         
        public LoginValidatorHandler()
        {

            RuleFor(x => x.UserName)
                .NotEmpty();

            RuleFor(x => x.Password)
                .NotEmpty();                 
        }         

    }
}
