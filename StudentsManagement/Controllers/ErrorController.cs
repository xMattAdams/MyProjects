using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentsManagement.Controllers
{
    public class ErrorController : Controller
    {
       [Route("Error/statusCode")]
        public IActionResult ErrorHandler(int statusCode)
        {

            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, your request cannot be made";
                    break;
            }
            

            return View("NotFound");
        }
    
    [Route("Error")]
    [AllowAnonymous]
    public IActionResult Error()
        {

            var details = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ExceptionPath = details.Path;
            ViewBag.ExceptionMessage = details.Error.Message;
            ViewBag.Stacktrace = details.Error.StackTrace;

            return View("ErrorView");

        }
    
    
    }
}