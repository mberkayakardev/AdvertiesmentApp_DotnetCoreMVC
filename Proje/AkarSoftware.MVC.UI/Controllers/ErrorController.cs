using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.MVC.UI.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;
        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }
        [Route("Error/GetErrors")]
        public IActionResult GetErrors()
        {
            var errors = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            _logger.LogError(DateTime.Now + " || Bir hata ile karşılaşıldı. :  " + errors.Path + " || " + errors.Error.Message + " || " + errors.RouteValues);
            return View();
        }

    }
}
