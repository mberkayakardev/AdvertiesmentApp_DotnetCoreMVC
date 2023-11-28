using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(ResultStatus.Error)
        {

        }

        public ErrorResult(string Messages) : base(ResultStatus.Error, Messages)
        {


        }
    }
}

