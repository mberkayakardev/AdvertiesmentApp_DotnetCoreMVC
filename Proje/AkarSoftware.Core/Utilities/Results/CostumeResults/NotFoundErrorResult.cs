using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class NotFoundErrorResult : Result
    {
        public NotFoundErrorResult() : base(ResultStatus.NotFound)
        {

        }
        public NotFoundErrorResult(string Message) : base(ResultStatus.NotFound, Message)
        {

        }
    }
}
