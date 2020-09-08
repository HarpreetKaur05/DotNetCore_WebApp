using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation; 
using MVCCore.Mediator.Request;

namespace MVCCore.Mediator.Handler.ValidatorHandler
{
   public class ChangePasswordValidator : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordValidator()
    {
        RuleFor(x => x.CurrentPassword)
            .NotEmpty();

        RuleFor(x => x.Password)
            .NotEmpty();
        RuleFor(x => x.ConfirmPassword)
            .NotEmpty().Equal(x => x.Password);
        
    }
}
}
