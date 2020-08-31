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
    public bool ValidateUser(string UserName, string Password)
    {
        if (UserName == "Harpreet" && Password == "1234")
            return true;
        else
            return false;
    }
    public Task<bool> Handle(Login request, CancellationToken cancellationToken)
    {
       
        throw new NotImplementedException();
    }
}
