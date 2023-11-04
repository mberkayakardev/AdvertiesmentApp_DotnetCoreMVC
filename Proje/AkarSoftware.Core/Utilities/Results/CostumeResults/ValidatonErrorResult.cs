using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class ValidatonErrorResult : Result
    {
        public ValidatonErrorResult(IEnumerable<ValidatonErrorResult> Errors) : base (ResultStatus.ValidationError, Errors)
        {
            
        }
        public ValidatonErrorResult(IEnumerable<ValidatonErrorResult> Errors, string Message) : base(ResultStatus.ValidationError, Message, Errors)
        {
            
        }

    }
}
