using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCCore.Mediator.Request;
using MVCCore.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Controllers
{
    public class AdministrationController : Controller
    {

        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        public AdministrationController(IMediator mediator, ILogger logger )            
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleRequest createRoleModel)
        {
            if (this.ModelState.IsValid)
            {
                try
                {
                    var response = await _mediator.Send(createRoleModel);
                    if (response == true)
                    {
                        ViewBag.SuccessMessage = "Role created successfully";
                    }
                    else
                    {
                        ViewBag.SuccessMessage = "There is some issue while craeting role .. Please try later";
                    }
                }
                catch (Exception ex)
                {
                    Log.Logger.Information(ex.Message);
                    _logger.Error("error in create role  controller" + ex.Message);
                    return View("Error");
                }
            }
            return View();
        }
    }
}
