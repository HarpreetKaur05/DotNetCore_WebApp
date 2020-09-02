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
using MVCCore.Mediator.Request;

namespace MVCCore.Controllers
{
    public class LoginController : Controller
    {
        private IMediator _mediator;   // Depency Injection to inject Imediator in asp.netcore
        private ILogin _login;
        public LoginController(IMediator mediator , ILogin login)
        {
            _mediator = mediator;
            _login = login;
        }

        // GET: LoginController
        public  IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest login)
        {
            if (this.ModelState.IsValid)
            {                
                try
                {
                    var response = await _mediator.Send(login);

                    if (response != "")
                     return  RedirectToAction("Index", "Home");                        
                    else
                        return View();
                }
                catch (Exception ex)
                {

                    return View("Error");
                }
            }
            else {
                ViewBag.SuccessMessage = "Not Authorized!";
                return View();
            }

           
        }
    }
}
