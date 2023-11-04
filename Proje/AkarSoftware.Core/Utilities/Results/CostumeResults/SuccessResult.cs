using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(ResultStatus.Success)
        {

        }

        public SuccessResult(string Message) : base(ResultStatus.Success, Message)
        {

        }
    }
}
