using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCCore.BL;
using MVCCore.Mediator.Request;
using Serilog;

namespace MVCCore.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMediator _mediator;
        private readonly  ILogger _logger; 

        public HomeController(IMediator mediator ,ILogger logger)
        {
            _logger = logger; 
            _mediator = mediator;
        }
         
        public IActionResult ListOfCustomer()
        { 
            return View();
        }

        [Authorize]
        public IActionResult CreateCustomer()
        {
            return View();
        }
    }
}
