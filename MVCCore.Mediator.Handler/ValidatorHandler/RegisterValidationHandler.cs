using FluentValidation;
using MVCCore.Mediator.Request;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MVCCore.Mediator.Handler.ValidatorHandler
{
   public class RegisterValidationHandler : AbstractValidator<RegisterRequest>
    {
        public RegisterValidationHandler()
        {
            RuleFor(x => x.UserName)
                .NotEmpty();

            RuleFor(x => x.Password)
                .NotEmpty();
            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().Equal(x => x.Password);

            RuleFor(x => x.Email).NotEmpty().EmailAddress();
        }
    }
}
