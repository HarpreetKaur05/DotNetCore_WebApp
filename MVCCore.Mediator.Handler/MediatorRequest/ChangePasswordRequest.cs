using MediatR;
using MVCCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCore.Mediator.Request
{
  public  class ChangePasswordRequest : ChangePasswordModel , IRequest<bool>
    {

    }
}
 