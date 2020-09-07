using System; 
using System.Threading.Tasks;
using MediatR; 
using Microsoft.AspNetCore.Mvc; 
using MVCCore.BL;
using MVCCore.Mediator.Request;
using Serilog;

namespace MVCCore.Controllers
{
    public class LoginController : Controller
    {
        private IMediator _mediator;   // Depency Injection to inject Imediator in asp.netcore
        private ILogin _login;
        private readonly ILogger _logger;
        private IRegister _register;
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
                    var response = await _mediator.Send(login);
                    if (response != 0)
                        return RedirectToAction("Index", "Home");
                    else
                        ViewBag.SuccessMessage = "Wrong Credentials, Please check username or password!";
                        return View();
                }
                catch(Exception ex)
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
                      var response =  await _mediator.Send(register);
                    if (response != 0)
                    {
                        return RedirectToAction("Login", "Login");
                    }
                    else {
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
