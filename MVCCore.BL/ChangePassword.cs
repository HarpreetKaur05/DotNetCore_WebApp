using MediatR; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; 
namespace MVCCore.BL
{
   public  class ChangePassword : IChangePassword , IRequest<bool>
    {
          private readonly UserManager<IdentityUser> _usermanager; 
          private readonly SignInManager<IdentityUser> _signinmanager;
          private readonly IHttpContextAccessor _contextAccessor;
        public ChangePassword(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signinmanager,  IHttpContextAccessor contextAccessor)
        { 
            _usermanager = userManager;
            _signinmanager = signinmanager;
            _contextAccessor = contextAccessor;
        }

        public async Task<bool> ChangeUserPassword (ChangePasswordModel changePasswordModel )
        { 
            var user = new IdentityUser
            {
                UserName = _contextAccessor.HttpContext.User.Identity.Name
            };
            var result = await _usermanager.ChangePasswordAsync(user, changePasswordModel.CurrentPassword , changePasswordModel.Password);             
            await _signinmanager.RefreshSignInAsync(user);
            return result.Succeeded; 
            
        }
    }

    
}
