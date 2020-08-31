using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MVCCore.BL;

namespace MVCCore.Controllers
{
    public class LoginController : Controller
    {
        private IMediator _mediator;   // Depency Injection to inject Imediator in asp.netcore
        private ILogin _login;
        public LoginController(IMediator mediator , ILogin login)
        {
            _mediator =  mediator;
            _login = login;
        }

        // GET: LoginController
        public IActionResult Login(Login login)
        {
            try
            {
                var response = _login.ValidateUser(login.UserName, login.Password);
                if (response == true)
                    return RedirectToAction("Index", "Doctors");
                else
                    return View();
            }
            catch(Exception ex){
                return  View("Error");
             }
            }

        
    }
}
