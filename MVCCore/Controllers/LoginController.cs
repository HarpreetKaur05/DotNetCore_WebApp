using System; 
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc; 
using MVCCore.BL;
using MVCCore.Mediator.Request;
using Serilog;

namespace MVCCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMediator _mediator;   // Dependency Injection to inject Imediator in asp.netcore
        private readonly ILogin _login;
        private readonly ILogger _logger;
        private readonly IRegister _register;

        public LoginController(IMediator mediator , ILogin login, ILogger logger, IRegister register) 
        {
            _mediator = mediator;
            _login = login;
            _logger = logger;
            _register = register;
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
                    HttpContext.Session.SetString("userEmail", login.Email);
                    var response = await _mediator.Send(login);
                    if (response  == true)
                        return RedirectToAction("ListOfCustomer", "Home");
                    else
                        ViewBag.SuccessMessage = "Wrong credentials or user does not exist";
                    return View();
                   
                }
                catch (Exception ex)
                {
                    _logger.Error("error in login controller" + ex.Message);
                    return View("Error");
                }
            }
            else
            {              
                return View();
            }
             
        }

        /******************************************************************
         *  Register Module
         * ******************************************************************/
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest register)
        {
            if(this.ModelState.IsValid)
            {
                try
                {
                    var response = await _mediator.Send(register);
                    if (response == true)
                    {
                        return RedirectToAction("Login", "Login");
                    }
                    else
                    {
                        ViewBag.SuccessMessage = "User Already exists, please login";
                    }
                }
                catch (Exception ex)
                {
                    _logger.Error("error in Register controller" + ex.Message);
                    return View("Error");
                }
            }
            return View();
        }

        /********************************************************************************************/
        public IActionResult ForgotPassword ()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(RegisterRequest register)
        {
            if (this.ModelState.IsValid)
            {
                try
                {
                    var response = await _mediator.Send(register);
                    if (response == true)
                    {
                        return RedirectToAction("Login", "Login");
                    }
                    else
                    {
                        ViewBag.SuccessMessage = "User Already exists, please login";
                    }
                }
                catch (Exception ex)
                {
                    _logger.Error("error in Register controller" + ex.Message);
                    return View("Error");
                }
            }
            return View();
        }

    }
}
