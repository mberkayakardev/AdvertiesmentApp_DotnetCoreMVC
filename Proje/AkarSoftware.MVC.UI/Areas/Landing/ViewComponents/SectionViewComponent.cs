using AkarSoftware.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.MVC.UI.Areas.Landing.ViewComponents.Sections
{
    [Area("Landing")]
    public class SectionViewComponent : ViewComponent
    {
        private readonly IProviderServicesService _providerServicesService;

        public SectionViewComponent(IProviderServicesService providerServicesService)
        {
            _providerServicesService = providerServicesService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _providerServicesService.GetAllServices();
            
            if (result.Status != ResultStatus.Success)
                TempData["Messages"] = result.Messages;

            else
                TempData["Messages"] = result.Messages;


            return View("_Section", result.Data);

        }
    }
}
