using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MVCCore.Models;
using AppContext = MVCCore.Models.AppContext;

namespace MVCCore.BL
{
    public class Login : ILogin, IRequest<bool>
    {
        private readonly AppContext _dbContext; 
        private readonly SignInManager<IdentityUser> _signinmanager;

        private readonly UserManager<IdentityUser> _userManager;
        public Login(AppContext context ,SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _dbContext = context; 
            _signinmanager = signInManager;
            _userManager = userManager;
        }

      
        public async Task<bool> ValidateUserWithIdentity(MVCCore.Models.Login login)
        {
            IdentityUser user = await _userManager.FindByEmailAsync(login.Email);
            if (user != null)
            {
                var result = await _signinmanager.PasswordSignInAsync(user.UserName, login.Password, false, lockoutOnFailure: false);
                return result.Succeeded;
            }
            return false;
        }      

    }

}
