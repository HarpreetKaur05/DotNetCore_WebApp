using MVCCore.Models;
using System.Threading.Tasks;

namespace MVCCore.BL
{
   public interface ILogin 
    { 
        public Task<bool> ValidateUserWithIdentity(MVCCore.Models. Login login);

    }
}
