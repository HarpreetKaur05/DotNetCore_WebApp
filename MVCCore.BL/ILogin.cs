 
using System.Threading.Tasks;

namespace MVCCore.BL
{
   public interface ILogin 
    {
        //public Task<int> ValidateUser( string username , string password);

        public Task<bool> ValidateUserWithIdentity(MVCCore.Models.Login login);


    }
}
