using AkarSoftware.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Managers.Abstract;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.MVC.UI.Areas.Landing.Controllers
{
    [Area("Landing")]
    public class HomeController : Controller
    {
        private readonly IProviderServicesService _providerServicesService;
        public HomeController(IProviderServicesService providerServicesService)
        {
            _providerServicesService = providerServicesService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            throw new Exception("Selamlar");
            var result = await _providerServicesService.GetAllServices();
            if (result.Status != ResultStatus.Success)
            {
                TempData["Messages"] = result.Messages;
            }
            return View(result.Data);
        }

    }
}
