using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class SuccessDataResult<T> : DataResult<T> 
    {
        public SuccessDataResult(T data, string Message) : base(data, ResultStatus.Success, Message)
        {

        }

        public SuccessDataResult(T data) : base(data, ResultStatus.Success)
        {

        }


    }
}
