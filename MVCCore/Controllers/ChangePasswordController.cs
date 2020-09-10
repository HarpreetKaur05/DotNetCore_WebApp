using System; 
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc; 
using MVCCore.BL;
using MVCCore.Mediator.Request;
using Serilog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http; 
namespace MVCCore.Controllers
{
     public class ChangePasswordController : Controller
    {
        private readonly IMediator _mediator;   // Dependency Injection to inject Imediator in asp.netcore
        private readonly ILogger _logger;
     
        public ChangePasswordController(IMediator mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordRequest model)
        {
            if (this.ModelState.IsValid)
            {
                try
                {
                    var response = await _mediator.Send(model);
                    if (response == true)
                    {
                        ViewBag.SuccessMessage = "Password changed successfully";
                    }
                    else
                    {
                        ViewBag.SuccessMessage = "There is some issue while chnging password.. Please try later";
                    }
                }
                catch (Exception ex)
                {
                    Log.Logger.Information(ex.Message);
                    _logger.Error("error in changepassword  controller" + ex.Message);
                    return View("Error");
                }
            }
            return View();
        }
    }
}
