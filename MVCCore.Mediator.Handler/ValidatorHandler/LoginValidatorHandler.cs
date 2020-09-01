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

            SetRules();
        }

        void SetRules()
        {
            RuleFor(x => x.UserName)
               .NotEmpty()
               .WithMessage("Please enter username");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Please enter password");


        }

    }
}
