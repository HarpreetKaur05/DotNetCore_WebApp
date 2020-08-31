using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCCore.Controllers
{
    public class LoginController : Controller
    {
        private IMediator _mediator;   // Depency Injection to inject Imediator in asp.netcore

        public LoginController(IMediator mediator)
        {
            _mediator =  mediator;
        }

        // GET: LoginController
        public IActionResult Login(Login login)
        {
            LoginHandler handler = new LoginHandler();
            bool response = handler.ValidateUser(login.UserName, login.Password);
            if (response == true)
                return RedirectToAction("index", "Doctors");
            else
                return View();
        
        }
        
        
    }
}
