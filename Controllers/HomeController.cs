using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCore.Models;
using MVCCore.StructureMap;

namespace MVCCore.Controllers
{
    public class HomeController : Controller
    {
       private readonly  ILogger<HomeController> _logger;
       private  IMessagingService _messageService;
         
        public HomeController(ILogger<HomeController> logger, IMessagingService messagingService)
        {
            _logger = logger;
            _messageService = messagingService;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _messageService.GetMessage();
            return View();
        }

          public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
