using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVCCore.Models;
using System; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace MVCCore.BL
{
    public class Register : IRegister, IRequest<bool>
    {
        private readonly Models.AppContext _dbContext;

        private readonly UserManager<IdentityUser> _usermanager;
        private readonly SignInManager<IdentityUser> _signinmanager;

        public static int intResponse = 0;
        public Register(Models.AppContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _dbContext = context;
            _usermanager = userManager;
            _signinmanager = signInManager;
        }

        public async Task<int> SaveNewUser(RegisterModel register)
        {
            var boolResponse = CheckUserExistsOrNot(register.Email);
            if (boolResponse.Result == true)
            { return intResponse = 0; }
            else
            {
                _dbContext.Add(register);
                intResponse = await _dbContext.SaveChangesAsync();
                return intResponse;
            }
        }

        public async Task<bool> CheckUserExistsOrNot(string email)
        {
            var response = await _dbContext.Register.Where(x => x.Email == email).Select(x => x.UserId).FirstOrDefaultAsync();
            if (response != 0)
                return true;
            else
                return false;
        }

        /*****************************************************************************************/
        public async Task<bool> CreateUserWithIdentity(RegisterModel register)
        {            
            var user = new IdentityUser
            {
                UserName = register.UserName,
                Email = register.Email
            };
            var result = await _usermanager.CreateAsync(user, register.Password);
            if (result.Succeeded){
                await _signinmanager.SignInAsync(user, isPersistent: false);
            }
            return result.Succeeded;
        }
    }
}

