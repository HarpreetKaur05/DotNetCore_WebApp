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
        public LoginController(IMediator mediator , ILogin login, ILogger logger)
        {
            _mediator = mediator;
            _login = login;
            _logger = logger;
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

        [HttpPost]
        public IActionResult Register()
            {
                return View();
            }
        
    }
}
