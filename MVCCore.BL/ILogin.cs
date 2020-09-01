using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.BL
{
   public interface ILogin 
    {
        public string ValidateUser( string username , string password);

    }
}
