using AkarSoftware.Managers.Abstract;
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
            var result = await _providerServicesService.GetAllServices();
            var model = result.Data;
            return View(model);
        }

    }
}
