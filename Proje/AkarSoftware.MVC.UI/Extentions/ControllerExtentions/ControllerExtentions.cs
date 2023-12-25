using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Core.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Managers.Concrete.Extentions.ControllerExtentions
{
    public static class ControllerExtentions
    {
        /// <summary>
        /// Controller extent edilecek Generic Parametre için method generic hale getirilir. Yönelenecek olan action name olması gerekiyor,
        /// birde alınacak olan input model belirtilmektedir. 
        /// </summary>
        public static IActionResult ResponseRedirectAction<T>(this Controller controller, IDataResult<T> Response, string ActionName, object inputmodel)
        {
            if (Response.Status == ResultStatus.NotFound)
            {
                return controller.NotFound();
            }

            if (Response.Status == ResultStatus.ValidationError)
            {
                foreach (var item in Response.ValidationErrors)
                {
                    controller.ModelState.AddModelError(item.Property, item.ErrorDescription);
                }
                return controller.View(inputmodel);
            }
            return controller.RedirectToAction(ActionName);
        }

        /// <summary>
        ///  Tekli yada Çoklu nesne listelemede kullanılır. view açılacaktır. Redirect olmuyorum bir view e gidiyorum.
        /// </summary>
        public static IActionResult ResponseView<T>(this Controller controller, IDataResult<T> Response)
        {
            if (Response.Status == ResultStatus.NotFound)
            {
                return controller.NotFound();
            }
            return controller.View(Response.Data);
        }


        // Silme işlemi gibi data taşımadan bir işlem gerçekleşecekse bunu kullanıyorduk.
        public static IActionResult ResponseRedirectAction(this Controller controller, Core.Utilities.Results.BaseResults.IResult result, string ActionName)
        {
            if (result.Status == ResultStatus.NotFound)
                return controller.NotFound();
            return controller.RedirectToAction(ActionName);
        }
    }
}
