using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR; 

namespace MVCCore.BL
{
    public class Login : ILogin , IRequest<string>
    {
        public Login()
        {
            
        }    
        
        public string ValidateUser( string username , string password)
        {
            return "Yes";
        }
    }
}
