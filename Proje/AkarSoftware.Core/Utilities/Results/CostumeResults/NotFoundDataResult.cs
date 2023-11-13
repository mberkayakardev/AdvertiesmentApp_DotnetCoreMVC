using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class NotFoundDataResult<T> : DataResult<T>
    {
        public NotFoundDataResult() : base (default, ResultStatus.NotFound)
        {
            
        }
        public NotFoundDataResult(string Message) : base(default, ResultStatus.NotFound, Message)
        {

        }
    }
}
