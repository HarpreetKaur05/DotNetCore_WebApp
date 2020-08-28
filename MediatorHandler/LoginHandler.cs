using MediatR;
using MVCCore;
using System;
using System.Threading;
using System.Threading.Tasks;

public class LoginHandler : IRequestHandler<Login,bool>
{
	public LoginHandler()
	{

	}

    public Task<bool> Handle(Login request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
