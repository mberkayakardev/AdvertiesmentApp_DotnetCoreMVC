using AkarSoftware.Core.Extentions.FluentValidation.ComplexType;
using FluentValidation.Results;

namespace AkarSoftware.Core.Extentions.FluentValidation.Concrete
{
    public static class FluentApiExtentions
    {
        public static List<ErrorModel> GetErrors(this ValidationResult result)
        {
            var errors = new List<ErrorModel>();
            foreach (var item in result.Errors)
            {
                errors.Add(new ErrorModel { ErrorDescription = item.ErrorMessage, Property = item.PropertyName });
            }
            return errors;
        }
    }
}
